using NUnit.Framework;

namespace Core.Tests;

[TestFixture]
public class DummyClassTests
{
	[Test]
	public void AlwaysPass()
	{
		Assert.Pass();
	}

	[Test]
	public void DummyFucTest()
	{
		IDummyInteface dummy = new DummyClass();

		var result = dummy.DummyFunc(4);
		var expected = 8;

		Assert.AreEqual(expected, result);
	}
}
