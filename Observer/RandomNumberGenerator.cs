using System;
using System.Collections.Generic;
using System.Text;

namespace _17_Observer
{
	class RandomNumberGenerator : NumberGenerator
	{
		Random random = new Random();
		int number;

		public override void Execute()
		{
			for(int i=0; i<20; i++)
			{
				number = random.Next(50);
				NotifyObservers();
			}
		}

		public override int GetNumber()
		{
			return number;
		}
	}
}
