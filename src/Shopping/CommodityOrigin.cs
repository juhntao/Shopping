namespace Shopping
{
	public class CommodityOrigin: ITaxable
	{
		public static readonly CommodityOrigin Imported = Create("Imported", TaxRate.ImportDuty);
		public static readonly CommodityOrigin Local = Create("Local", TaxRate.Exempt);
		public static CommodityOrigin Create(string name, TaxRate taxRate) => new CommodityOrigin(name, taxRate);

		private CommodityOrigin(string name, TaxRate taxRate)
		{
			Name = name;
			TaxRate = taxRate;
		}

		public string Name { get; }
		public TaxRate TaxRate { get; }

		public Money Calculate(Money price)
		{
			return TaxRate.Calculate(price);
		}
	}
}
