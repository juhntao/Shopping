namespace Shopping
{
	public interface ITaxable
	{
		Money Calculate(Money price);
	}
}
