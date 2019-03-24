using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDecorator.Decorator
{
	/// <summary>
	/// The 'ConcreteComponent' class
	/// </summary>
	class ConcreteComponent : IComponent
	{
		public void Operation()
		{
			Console.WriteLine("ConcreteComponent.Operation()");
		}
	}
}
