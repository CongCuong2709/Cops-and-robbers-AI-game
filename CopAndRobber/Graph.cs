using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopAndRobber
{
	internal class Graph
	{
		private int V;
		private int E;

		private Dictionary<int, point>[] adj;
		private int[] rate;

		public Graph(GameLogic gameLogic ,int v)
		{
			this.V = v;
			this.E = 0;

			rate = new int[V];
			adj = new Dictionary<int, point>[v];

			for(int num = 0; num < V; num++)
			{
				adj[num] = new Dictionary<int, point>();
			}

			this.readFromFile("NodeList.txt");
			//createGraph(gameLogic);
			//DialogResult dialogResult = MessageBox.Show(this.ToString(), "", MessageBoxButtons.YesNo);
		}

		public int getRate(int vertex)
		{
			return rate[vertex];
		}

		public int getV()
		{
			return this.V;
		}

		public int getE()
		{
			return this.E;
		}


		public void addEdge(int source, int destination, int distance)
		{
			point destinationPoint = new point(destination, distance, 0, 0, 0);
			adj[source].Add(destination, destinationPoint);
			rate[source] = 0;
			rate[destination] = 0;
			E++;
		}

		public void readFromFile(string fileName)
		{
			try
			{
				string path = Path.Combine(Directory.GetCurrentDirectory(), "Assets\\" + fileName);
				using (StreamReader sr = new StreamReader(path))
				{
					while (!sr.EndOfStream)
					{
						string line = sr.ReadLine();
						string[] paths = line.Split(' ');
						int id = int.Parse(paths[0]);

						if (paths.Length > 4)
						{

							for (int index = 4; index < paths.Length; index++)
							{
								this.addEdge(id ,int.Parse(paths[index]), 1);
							}
						}
					}
				}
			}
			catch (Exception e)
			{
				//DialogResult dialogResult = MessageBox.Show(
					//"Chưa đọc file NodeList cho A*", " ", MessageBoxButtons.YesNo);
			}
		}

		public void createGraph(GameLogic gameLogic)
		{
			foreach(NodeActor node in gameLogic.getListNode().Values)
			{
				foreach(int desID in node.getNodeAdj())
				{
					this.addEdge(node.getID(), desID, 1);
				}
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"Graph with {V} vertices and {E} edges:");

			foreach (var vertex in adj)
			{
				sb.AppendLine($"Vertex {vertex.Count}:");
				foreach (var point in vertex.Values)
				{
					sb.AppendLine($"\t -> {point}");
				}
			}

			return sb.ToString();
		}

		public Dictionary<int, point> getAdj(int source)
		{
			return adj[source];
		}


		public class point
		{
			private int id;
			private int distance;
			private int hv;
			private int gv;
			private int fv;

			public point(int id, int distance, int hv, int gv, int fv)
			{
				this.id = id;
				this.distance = distance;
				this.hv = hv;
				this.gv = gv;
				this.fv = fv;
			}

			public override string ToString()
			{
				return id + "-" + fv; ;
			}

			public int getId()
			{
				return this.id;
			}

			public void setId(int id)
			{
				this.id = id;
			}

			public int getDistance()
			{
				return this.distance;
			}

			public void setDistance(int distance)
			{
				this.distance = distance;
			}



			public int getHv()
			{
				return this.hv;
			}

			public void setHv(int hv)
			{
				this.hv = hv;
			}

			public int getGv()
			{
				return this.gv;
			}

			public void setGv(int gv)
			{
				this.gv = gv;
			}

			public int getFv()
			{
				return this.fv;
			}

			public void setFv(int fv)
			{
				this.fv = fv;
			}

			public void set(int id, int distance, int hv, int gv, int fv)
			{
				this.id = id;
				this.distance = distance;
				this.hv = hv;
				this.gv = gv;
				this.fv = fv;
			}


		}
	}
}
