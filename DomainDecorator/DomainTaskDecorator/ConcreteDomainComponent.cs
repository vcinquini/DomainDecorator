using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDecorator.DomainTaskDecorator
{
	/// <summary>
	/// The 'ConcreteComponent' class
	/// </summary>
	class ConcreteDomainComponent : IDomainComponent
	{
		public void GetFinalList(Domain request)
		{
			Console.WriteLine("ConcreteDomainComponent.GetFinalList() was called");
		}
	}
}
