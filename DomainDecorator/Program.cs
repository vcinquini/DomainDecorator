using DomainDecorator.Decorator;
using DomainDecorator.DomainTaskDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDecorator
{
	class Program
	{
		List<Domain> domainList = new List<Domain>();

		static void Main(string[] args)
		{
			Domain request;
			Program p = new Program();
			p.InitializeList();

			request = new Domain() { Codigo = "", Descricao = "AAA"};

			#region Original
			/*
			List<Domain> res = p.Query1(request);
			foreach (var item in res)
				Console.WriteLine("{0}-{1}", item.Codigo, item.Descricao);
			Console.WriteLine();

			request = new Domain() { Codigo = "005"};
			res = p.Query2(request);
			foreach (var item in res)
				Console.WriteLine("{0}-{1}", item.Codigo, item.Descricao);
			// end
			Console.ReadKey();
			*/
			#endregion

			#region Decorator Template
			/*
			// Create ConcreteComponent and two Decorators
			ConcreteComponent c = new ConcreteComponent();
			ConcreteDecoratorA d1 = new ConcreteDecoratorA();
			ConcreteDecoratorB d2 = new ConcreteDecoratorB();

			// Link decorators
			d1.SetComponent(c);
			d2.SetComponent(d1);

			d2.Operation();
			*/
			#endregion

			// Create ConcreteComponent and two Decorators
			ConcreteDomainComponent c = new ConcreteDomainComponent();
			DomainFilterDecorator d1 = new DomainFilterDecorator();
			DomainSortDecorator d2 = new DomainSortDecorator();

			// Link decorators
			d1.SetComponent(c);
			d2.SetComponent(d1);

			d2.GetFinalList(request);

			// Wait for user
			Console.ReadKey();
		}

		private List<Domain> Query1(Domain request)
		{
			List<Domain> lista = domainList.Where(p =>
						p.Codigo == request.Codigo ||
						p.Descricao.Contains(request.Descricao))
			   .OrderBy(o => o.Descricao)
			   .ToList<Domain>()
			   ;

			return lista;
		}
		private List<Domain> Query2(Domain request)
		{
			List<Domain> lista = domainList.Where(p =>
						p.Codigo == request.Codigo )
			   .OrderBy(o => o.Codigo)
			   .ToList<Domain>()
			   ;
			return lista;
		}

		private void InitializeList()
		{
			for (int i = 0; i < 10; i++)
			{
				for (char a = (char)65; a < (char)91; a++)
				{
					domainList.Add(new Domain() { 
						Codigo = i.ToString("000"),
						Descricao =	String.Format("DESC_{0}{0}{0}_{1:000}", a, i)
					});
				}
			}
		}
	}

	class Domain
	{
		public string Codigo { get; set; }
		public string Descricao { get; set; }
	}
}
