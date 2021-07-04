using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CookingPrototype.Kitchen {
	public sealed class Order {
		public class OrderFood {
			public string Name  { get; } = null;
			public string Needs { get; } = null;

			public OrderFood(string name, string needs) {
				Name  = name;
				Needs = needs;
			}
		}

		public string Name { get; } = null;
		public ReadOnlyCollection<OrderFood> Foods { get { return _foods.AsReadOnly(); } }

		List<OrderFood> _foods;

		public Order(string name, List<OrderFood> foods) {
			Name   = name;
			_foods = foods;
		}
	}
}
