using System;
using NUnit.Framework;

namespace FeatureShare.Library.Tests
{
	[TestFixture]
	public class WidgetTests
	{
		[Test]
		public void AddReturnsResult()
		{
			Assert.That(new Widget().Add(2, 3), Is.EqualTo(5));
		}
	}
}
