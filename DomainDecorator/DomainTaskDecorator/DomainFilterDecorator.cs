using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDecorator.DomainTaskDecorator
{
	/// <summary>
	/// The 'ConcreteDecoratorA' class
	/// </summary>
	class DomainFilterDecorator : DomainDecorator
	{
		public override void GetFinalList(Domain request)
		{
			base.GetFinalList(request);

			// add filter here

			Console.WriteLine("DomainFilterDecorator.GetFinalList() was called");
		}
	}
}
