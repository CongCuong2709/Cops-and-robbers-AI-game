using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
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

		public void search(Graph G, int source, int sourceHv, int finish)
		{
			int resultDistance = 0;
			StringBuilder res = new StringBuilder();
			res.Append("Trang thai| TTK | K(u,v) | h(v) | g(v) | f(v) | danh sach L\n");
			List<Graph.point> queue = new List<Graph.point>();


			marked.Add(new markedPoint(source, 0)); // Mark the source
			queue.Add(new Graph.point(source, 0, sourceHv, 0, 0)); // put source vertice on the queue.
			while (queue.Count > 0)
			{
				Graph.point sourcePoint = queue[0];     // Remove next vertex from the queue.
				queue.RemoveAt(0);
				int sourceGv = sourcePoint.getGv();
				int src = sourcePoint.getId();

				res.Append($"{src}-{G.getRate(src)}|");
				if (src == finish)
				{
					res.Append("TTKT\n\n");
					resultDistance = sourcePoint.getFv();
					break;
				}

				foreach (var destination in G.getAdj(src))
				{
					Graph.point destinationPoint = destination.Value;
					int destinationName = destination.Key;
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

						queue.Sort((kv1, kv2) => kv1.getFv().CompareTo(kv2.getFv()));

						res.Append($"{destinationName}-{destinationHv}|");
						res.Append($"{kuv}|");
						res.Append($"{hv}|");
						res.Append($"{gv}|");
						res.Append($"{fv}|");

						res.Append(" ");
					}


				}

				res.Append("\n");
				res.Append(new string('-', 60));
				res.Append("\n");


			}

			if (!hasPathTo(G, finish))
			{
				res.Append($"\nKhong ton tai duong di tu {source} den {finish}");
			}
			else
			{
				res.Append($"Duong di tu {source} den {finish}\n");
				foreach (var character in getEdgeTo(G, finish))
				{
					res.Append($"{character}-{G.getRate(character)} -> ");
				}
				res.Remove(res.Length - 4, 4);
				res.Append($"   Do dai: {resultDistance}");
			}

			Console.WriteLine(res.ToString());
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

		public List<int> getEdgeTo(Graph G, int v)
		{
			if (!hasPathTo(G, v)) return null;
			List<int> path = new List<int>();
			for (int x = v; x != s; x = edgeTo[x])
			{
				path.Insert(0, x);
			}
			path.Insert(0, s);
			return path;
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

