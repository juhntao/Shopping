using System;

namespace Shopping
{
	public struct Money
	{
		public static implicit operator Money(double money) => Of(money);
		public static implicit operator double(Money money) => money.Value;
		public static Money operator +(Money left, Money right) => Of(left.Value + right.Value);
		public static Money Of(double value) => new Money(value);

		private Money(double value)
		{
			Value = value;
		}
		
		public double Value { get; }
		public double Round() => Math.Round(Value, 2);

		public override string ToString() => Value.ToString();
	}
}
