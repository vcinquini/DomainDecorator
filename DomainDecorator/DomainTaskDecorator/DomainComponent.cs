using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDecorator.DomainTaskDecorator
{
	/// <summary>
	/// The 'Component' abstract class
	/// </summary>
	interface IDomainComponent
	{
		void GetFinalList(Domain request);
	}
}
