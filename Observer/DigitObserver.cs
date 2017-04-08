using System;
using System.Collections.Generic;
using System.Text;

namespace _17_Observer
{
	class DigitObserver : IObserver
	{
		public void Update(NumberGenerator generator)
		{
			Console.WriteLine(this.GetType().FullName + ":" + generator.GetNumber());

			try
			{
				System.Threading.Thread.Sleep(100);
			}
			catch
			{

			}
		}
	}
}
