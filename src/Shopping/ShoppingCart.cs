using System.Collections.Generic;

namespace Shopping
{
	public sealed class ShoppingCart
	{
		public static ShoppingCart Create() => new ShoppingCart();
		private readonly IList<Commodity> _commodities;

		private ShoppingCart()
		{
			_commodities = new List<Commodity>();
		}

		public ShoppingCart Add(Commodity commodity)
		{
			_commodities.Add(commodity);
			return this;
		}

		public Receipt Checkout()
		{
			return new Receipt(_commodities);
		}
	}
}
