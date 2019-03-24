using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDecorator.DomainTaskDecorator
{
	/// <summary>
	/// The 'Decorator' abstract class
	/// </summary>
	abstract class DomainDecorator : IDomainComponent
	{
		protected IDomainComponent component;

		public void SetComponent(IDomainComponent component)
		{
			this.component = component;
		}

		public virtual void GetFinalList(Domain request)
		{
			if (component != null)
			{
				component.GetFinalList(request);
			}
		}
	}
}
