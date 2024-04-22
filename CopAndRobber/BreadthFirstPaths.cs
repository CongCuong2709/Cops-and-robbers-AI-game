using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopAndRobber
{
	internal class BreadthFirstPaths
	{
		private bool[] marked;               // Is a shortest path to this vertex known?
		private int[] edgeTo;                // last vertex on known path to this vertex
		private readonly int s;              // source
		private readonly string output;

		public BreadthFirstPaths(Graph G)
		{
			marked = new bool[G.VCount()];
			edgeTo = new int[G.VCount()];
			//this.s = s;
			bfs(G, s);
		}

		public BreadthFirstPaths(Graph G, int s, string output)
		{
			marked = new bool[G.VCount()];
			edgeTo = new int[G.VCount()];
			this.s = s;
			this.output = output;
			bfs(G, s);
		}

		public void bfs(Graph G, int source)
		{
			for(int i = 0; i < edgeTo.Length; i++)
			{
				edgeTo[i] = 0;
				marked[i] = false;
			}
			
			Queue<int> queue = new Queue<int>();
			marked[source] = true;                  
			queue.Enqueue(source);                  

			while (queue.Count > 0)
			{
				int src = queue.Dequeue();          

				foreach (int destination in G.Adj(src))
				{
					if (!marked[destination])       
					{
						edgeTo[destination] = src;  
						marked[destination] = true; 
						queue.Enqueue(destination); 
					}
				}
			}
		}

		public bool HasPathTo(int v)
		{
			return marked[v];
		}

		public IEnumerable<int> PathTo(int v)
		{
			if (!HasPathTo(v)) return null;

			Stack<int> path = new Stack<int>();
			for (int x = v; x != s; x = edgeTo[x])
			{
				path.Push(x);
			}
			//path.Push(s);
			path.Pop();
			return path;
		}

		public void PrintPaths(Graph G, int start, int finish)
		{
			string res = "Phat trien TT||Trang thai ke || Danh sach L\n";
			Queue<int> queue = new Queue<int>();
			marked[start] = true;                  // Mark the source
			queue.Enqueue(start);                  // put source vertex on the queue.

			while (queue.Count > 0)
			{
				int src = queue.Dequeue();         // Remove next vertex from the queue.

				res += $"{src,-13}||";
				if (src == finish)
				{
					res += $"{"TTKT",-14}||\n";
					break;
				}

				string resAdj = "";
				foreach (int adj in G.Adj(src))
				{
					resAdj += adj + " ";
				}
				res += $"{resAdj,-14}||";

				foreach (int destination in G.Adj(src))
				{
					if (!marked[destination])      // for each unmarked adjacent point
					{
						edgeTo[destination] = src; // save last edge on a shortest path,
						marked[destination] = true;// mark it because path is known,
						queue.Enqueue(destination); // and add it to the queue.
					}
				}

				foreach (int item in queue)
				{
					res += item + " ";
				}

				res += "\n";
			}

			if (!HasPathTo(finish))
			{
				res += $"Khong ton tai duong di tu {start} den {finish}";
			}
			else
			{
				res += $"Duong di tu {start} den {finish}\n";
				foreach (int character in PathTo(finish))
				{
					res += character + " -> ";
				}
				res = res.Substring(0, res.Length - 3);
			}

			try
			{
				using (StreamWriter writer = new StreamWriter(output))
				{
					// Ghi dữ liệu vào file
					writer.Write(res);
					Console.WriteLine("Data has been written to the file.");
				}
			}
			catch (IOException e)
			{
				// Xử lý nếu có lỗi xảy ra trong quá trình ghi
				Console.WriteLine("Error writing to file: " + e.Message);
			}

			Console.WriteLine(res);
		}
	}
}
