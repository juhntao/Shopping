using System.Collections.Generic;
using System.Linq;

namespace Shopping
{
	public class Receipt
	{
		public Receipt(IEnumerable<Commodity> commodities)
		{
			Commodities = (commodities ?? Enumerable.Empty<Commodity>()).ToList();
		}

		public IEnumerable<Commodity> Commodities { get; }
		public Money TotalAmount => Money.Of(TotalPrice + TotalTax);
		public Money TotalPrice => Commodities.Select(x => x.Price).Sum(x => x);
		public Money TotalTax => Commodities.Select(x => x.Calculate()).Sum(x => x);
	}
}
