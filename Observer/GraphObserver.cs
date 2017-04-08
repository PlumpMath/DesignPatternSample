using System;
using System.Collections.Generic;
using System.Text;

namespace _17_Observer
{
	class GraphObserver : IObserver
	{
		public void Update(NumberGenerator generator)
		{
			Console.Write(this.GetType().FullName + ":");
			int count = generator.GetNumber();

			for(int i=0; i<count; i++)
			{
				Console.Write("*");
			}
			Console.WriteLine();

			try
			{
				System.Threading.Thread.Sleep(100);
			}
			catch { }
		}
	}
}
