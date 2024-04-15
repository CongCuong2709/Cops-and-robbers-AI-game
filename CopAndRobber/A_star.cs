using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CopAndRobber
{
	internal class A_star
	{
		private HashSet<markedPoint> marked; // Is a shortest path to this vertex known?
		private int[] edgeTo; // last vertex on known path to this vertex
		private int s; // source

		public A_star(Graph G, int source, int end)
		{
			marked = new HashSet<markedPoint>();
			edgeTo = new int[G.getV()];
			this.s = source;
		}

		public A_star(Graph G)
		{
			marked = new HashSet<markedPoint> ();
			edgeTo = new int[G.getV()];
		}

		public void search(Graph G, int source, int finish)
		{
			for (int index = 0; index < edgeTo.Length; index++)
			{
				edgeTo[index] = 0;
			}

			marked.Clear();

			int resultDistance = int.MaxValue;
			List<Graph.point> queue = new List<Graph.point>();


			marked.Add(new markedPoint(source, 0)); // Mark the source
			queue.Add(new Graph.point(source, 0, 0, 0, 0)); // put source vertice on the queue.
			while (queue.Count > 0)
			{
				Graph.point sourcePoint = queue[0];     // Remove next vertex from the queue.
				queue.RemoveAt(0);
				int sourceGv = sourcePoint.getGv();
				int src = sourcePoint.getId();


				/*if (src == finish)
				{		
					bool flagNoNeedMoreSearch = true;
					foreach(var point  in queue)
					{
						if(point.getId() == finish && point.getFv() <= resultDistance)
						{
							resultDistance = sourcePoint.getFv();
							flagNoNeedMoreSearch = false;
							break;
						}
					}

					if (flagNoNeedMoreSearch)
					{
						resultDistance = sourcePoint.getFv();
						break;
					}
					break;
				}*/

				/*if (src == finish)
				{
					resultDistance = sourcePoint.getFv();
					break;
				}*/

				foreach (var destination in G.getAdj(src))
				{
					Graph.point destinationPoint = destination.Value;
					int destinationName = destination.Value.getId();
					int destinationHv = destinationPoint.getHv();
					int destinationFv = destinationPoint.getFv();

					if (!marked.Contains(new markedPoint(destinationName, destinationFv)))
					{
						int kuv = destinationPoint.getDistance();
						int hv = destinationPoint.getHv();
						int gv = sourceGv + kuv;
						int fv = gv + hv;

						edgeTo[destinationName] = src; // save last edge on a shortest path,
						marked.Add(new markedPoint(destinationName, fv));

						destinationPoint.set(destinationName, kuv, hv, gv, fv);
						queue.Add(destinationPoint);

						if (destinationName == finish)
						{
							resultDistance = destinationPoint.getFv();
							return;
						}
						queue.Sort((kv1, kv2) => kv1.getFv().CompareTo(kv2.getFv()));

					}


				}


				/*DialogResult dialogResult = MessageBox.Show(queue.Count.ToString(), " ", MessageBoxButtons
					.YesNo);*/
			}

			if (!hasPathTo(G, finish))
			{
				
				DialogResult dialogResult = MessageBox.Show("Ko co duong di", " ", MessageBoxButtons.YesNo);
			}
			else
			{
				/*DialogResult result = MessageBox.Show(getEdgeTo(G, 256).ToString(), "",
					MessageBoxButtons.YesNo);*/
				DialogResult dialogResult = MessageBox.Show("co duong di", " ", MessageBoxButtons.YesNo);
				
				
			}


		}


		public bool hasPathTo(Graph G, int v)
		{
			foreach (markedPoint p in marked)
			{
				if (p.getName() == v)
					return true;
			}
			return false;
		}

		public Stack<int> getEdgeTo(Graph G, int finish)
		{
			Stack<int> path = new Stack<int>();
			if (!hasPathTo(G, finish))
			{
				DialogResult dialogResult = MessageBox.Show("Kho co edge to", " ", MessageBoxButtons.YesNo);
				path.Push(finish);
				return path;
			}
			else
			{
				for (int x = finish; x != s; x = edgeTo[x])
				{
					path.Push(x);
				}
				path.Pop();
				return path;
			}
			
		}

	}

	class markedPoint
	{
			private int name;
			private int value;

			public markedPoint(int name, int value)
			{
				this.name = name;
				this.value = value;
			}

			public int getName()
			{
				return name;
			}

			public int getValue()
			{
				return value;
			}
	}
	
}

