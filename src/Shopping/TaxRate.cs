namespace Shopping
{
	public class TaxRate
	{
		public static readonly TaxRate Exempt = new TaxRate("Tax Exempt", 0.0);
		public static readonly TaxRate SalesTax = new TaxRate("Sales Tax", 0.1);
		public static readonly TaxRate ImportDuty = new TaxRate("Import Duty", 0.05);

		public string Name { get; }
		public double Rate { get; }

		private TaxRate(string name, double rate)
		{
			Name = name;
			Rate = rate;
		}

		public Money Calculate(Money price)
		{
			return price * Rate;
		}
	}
}
