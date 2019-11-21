namespace Shopping
{
	public sealed class Commodity
	{
		public static readonly Commodity Book = Create("book", 12.49, CommodityOrigin.Local, TaxRateCategory.Book);
		public static readonly Commodity MusicCD = Create("music CD", 14.99, CommodityOrigin.Local, TaxRateCategory.SalesTax);
		public static readonly Commodity Chocolate = Create("chocolate bar", 0.85, CommodityOrigin.Local, TaxRateCategory.Food);
		public static readonly Commodity Perfume = Create("perfume", 18.99, CommodityOrigin.Local, TaxRateCategory.SalesTax);
		public static readonly Commodity HeadachePills = Create("headache pills", 9.75, CommodityOrigin.Local, TaxRateCategory.Medical);
		public static readonly Commodity ImportedChocolate = Create("chocolates", 10.00, CommodityOrigin.Imported, TaxRateCategory.Food);
		public static readonly Commodity ImportedPerfume = Create("perfume", 47.50, CommodityOrigin.Imported, TaxRateCategory.SalesTax);

		public static Commodity Create(string name, Money price, CommodityOrigin origin, TaxRateCategory category)
			=> new Commodity(name, price, origin, category);

		private Commodity(string name, Money price, CommodityOrigin origin, TaxRateCategory category)
		{
			Name = name;
			Price = price;
			Origin = origin;
			Category = category;
		}

		public string Name { get; }
		public Money Price { get; set; }
		public CommodityOrigin Origin { get; }
		public TaxRateCategory Category { get; }

		public Money Calculate()
			=> Category.Calculate(Price) + Origin.Calculate(Price);
	}
}
