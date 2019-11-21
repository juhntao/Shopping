namespace Shopping
{
	public class TaxRateCategory: ITaxable
	{
		public static readonly TaxRateCategory Book = new TaxRateCategory("Book", TaxRate.Exempt);
		public static readonly TaxRateCategory Food = new TaxRateCategory("Food", TaxRate.Exempt);
		public static readonly TaxRateCategory Medical = new TaxRateCategory("Medical", TaxRate.Exempt);
		public static readonly TaxRateCategory SalesTax = new TaxRateCategory("SalesTax", TaxRate.SalesTax);

		public TaxRateCategory(string name, TaxRate taxRate)
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
