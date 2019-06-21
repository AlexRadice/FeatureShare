using NUnit.Framework;
using TechTalk.SpecFlow;

namespace FeatureShare.Library.Tests.Steps
{
	[Binding]
	class WidgetSteps
	{
		private readonly WidgetContext _widgetContext;

		public WidgetSteps(WidgetContext widgetContext)
		{
			_widgetContext = widgetContext;
		}

		[Given(@"I have a widget")]
		public void GivenIHaveAWidget()
		{
			_widgetContext.WidgetUnderTest = new Widget();
		}

		[When(@"I add (.*) to (.*)")]
		public void WhenIAddTo(int arg1, int arg2)
		{
			_widgetContext.Result = _widgetContext.WidgetUnderTest.Add(arg1, arg2);
		}

		[Then(@"the result should be (.*)")]
		public void ThenTheResultShouldBe(int expectedResult)
		{
			Assert.That(_widgetContext.Result, Is.EqualTo(expectedResult));
		}

	}
}
