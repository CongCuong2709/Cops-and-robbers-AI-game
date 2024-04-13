using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		}

		public int getRate(int vertex)
		{
			return rate[vertex];
		}

		public int getV()
		{
			return V;
		}

		public int getE()
		{
			return E;
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

			}
		}


		public Dictionary<int, point> getAdj(int source)
		{
			return adj[source];
		}

		public int getGv(int c)
		{
			return 0;
		}

		public int getFv(int c)
		{
			return 0;
		}

		public int getDistance(int c)
		{
			return 0;
		}

		public int getid(int c)
		{
			return 0;
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
				return id;
			}

			public void setId(int id)
			{
				this.id = id;
			}

			public int getDistance()
			{
				return distance;
			}

			public void setDistance(int distance)
			{
				this.distance = distance;
			}



			public int getHv()
			{
				return hv;
			}

			public void setHv(int hv)
			{
				this.hv = hv;
			}

			public int getGv()
			{
				return gv;
			}

			public void setGv(int gv)
			{
				this.gv = gv;
			}

			public int getFv()
			{
				return fv;
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
