using System;
using System.Collections.Generic;
using System.Text;

namespace _17_Observer
{
	interface IObserver
    {
		void Update(NumberGenerator generator);
    }
}
