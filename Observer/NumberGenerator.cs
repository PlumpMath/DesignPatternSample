using System;
using System.Collections.Generic;
using System.Text;

namespace _17_Observer
{
    abstract class NumberGenerator
    {
		List<IObserver> observers = new List<IObserver>();

		/// <summary>
		/// observerの追加
		/// </summary>
		/// <param name="obserer"></param>
		public void AddObserver(IObserver obserer)
		{
			observers.Add(obserer);
		}

		/// <summary>
		/// ovserverの削除
		/// </summary>
		/// <param name="observer"></param>
		public void DeleteObserver(IObserver observer)
		{
			observers.Remove(observer);
		}

		/// <summary>
		/// observerへ通知
		/// </summary>
		public void NotifyObservers()
		{
			 foreach(IObserver observer in observers)
			{
				observer.Update(this);
			}
		}

		public abstract int GetNumber();

		public abstract void Execute();
	}
}
