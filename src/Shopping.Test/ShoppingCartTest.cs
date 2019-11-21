using Xunit;
using System;

namespace Shopping.Test
{
	public class ShoppingCartTest
	{
		[Fact]
		public void EmptyShoppingCart_CheckoutTest()
		{
			var result = ShoppingCart.Create().Checkout();
			Assert.NotNull(result);
			Assert.Equal(0, result.TotalAmount.Round());
			Assert.Equal(0, result.TotalPrice.Round());
			Assert.Equal(0, result.TotalTax.Round());
		}

		[Fact]
		public void Input1ShoppingCart_CheckoutTest()
		{
			var shoppingCart = ShoppingCart.Create()
				.Add(Commodity.Book)
				.Add(Commodity.MusicCD)
				.Add(Commodity.Chocolate);

			var result = shoppingCart.Checkout();
			Assert.NotNull(result);
			Assert.Equal(29.83, result.TotalAmount.Round());
			Assert.Equal(1.50, result.TotalTax.Round());
		}
	}
}
