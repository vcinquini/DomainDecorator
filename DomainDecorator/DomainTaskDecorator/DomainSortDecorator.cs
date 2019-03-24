using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDecorator.DomainTaskDecorator
{
	/// <summary>
	/// The 'ConcreteDecoratorB' class
	/// </summary>
	class DomainSortDecorator : DomainDecorator
	{
		public override void GetFinalList(Domain request)
		{
			base.GetFinalList(request);
			AddedBehavior();
			Console.WriteLine("DomainSortDecorator.GetFinalList() was called");
		}

		void AddedBehavior()
		{
			Console.WriteLine("DomainSortDecorator.AddedBehavior() was called");
		}
	}
}
