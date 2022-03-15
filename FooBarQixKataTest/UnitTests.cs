using KataFooBarQix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FooBarQixKataTest
{
    [TestClass]
    public class UnitTests
    {
		FooBarQixGenerator fooBarQix = new FooBarQixGenerator();

		[TestMethod]
		public void ShouldReturn1WhenNumber1()
		{
			var value = fooBarQix.DetermineValueOf(1);
			Assert.AreEqual("1", value);
		}

		[TestMethod]
		public void ShouldReturn2WhenNumber2()
		{
			var value = fooBarQix.DetermineValueOf(2);
			Assert.AreEqual("2", value);
		}

		[TestMethod]
		public void ShouldReturnFooFooWhenNumber3()
		{
			string value = fooBarQix.DetermineValueOf(3);
			Assert.AreEqual("FooFoo", value);
		}

		[TestMethod]
		public void ShouldReturn4WhenNumber4()
		{
			string value = fooBarQix.DetermineValueOf(4);
			Assert.AreEqual("4", value);
		}

		[TestMethod]
		public void ShouldReturnBarBarWhenNumber5()
		{
			string value = fooBarQix.DetermineValueOf(5);
			Assert.AreEqual("BarBar", value);
		}

		[TestMethod]
		public void ShouldReturnFooWhenNumber6()
		{
			string value = fooBarQix.DetermineValueOf(6);
			Assert.AreEqual("Foo", value);
		}

		[TestMethod]
		public void ShouldReturnQixWhenNumber7()
		{
			string value = fooBarQix.DetermineValueOf(7);
			Assert.AreEqual("Qix", value);
		}

		[TestMethod]
		public void ShouldReturn8WhenNumber8()
		{
			string value = fooBarQix.DetermineValueOf(8);
			Assert.AreEqual("8", value);
		}

		[TestMethod]
		public void ShouldReturnFooWhenNumber9()
		{
			string value = fooBarQix.DetermineValueOf(9);
			Assert.AreEqual("Foo", value);
		}

		[TestMethod]
		public void ShouldReturnBarWhenNumber10()
		{
			string value = fooBarQix.DetermineValueOf(10);
			Assert.AreEqual("Bar", value);
		}

		[TestMethod]
		public void ShouldReturnFooBarWhenNumber51()
		{
			string value = fooBarQix.DetermineValueOf(51);
			Assert.AreEqual("FooBar", value);
		}

		[TestMethod]
		public void ShouldReturnBarFooWhenNumber53()
		{
			string value = fooBarQix.DetermineValueOf(53);
			Assert.AreEqual("BarFoo", value);
		}

		[TestMethod]
		public void ShouldReturnFooWhenNumber13()
		{
			string value = fooBarQix.DetermineValueOf(13);
			Assert.AreEqual("Foo", value);
		}

		[TestMethod]
		public void ShouldReturnFooBarBarWhenNumber15()
		{
			string value = fooBarQix.DetermineValueOf(15);
			Assert.AreEqual("FooBarBar", value);
		}

		[TestMethod]
		public void ShouldReturnFooFooFooWhenNumber33()
		{
			string value = fooBarQix.DetermineValueOf(33);
			Assert.AreEqual("FooFooFoo", value);
		}

		[TestMethod]
		public void ShouldReturnFooQixWhenNumber27()
		{
			string value = fooBarQix.DetermineValueOf(27);
			Assert.AreEqual("FooQix", value);
		}
	}
}