using Microsoft.AspNetCore.Mvc.Filters;

namespace filters_tut.Filters
{
	public class TestingOrderedFilterAttribute : Attribute, IOrderedFilter, IActionFilter
	{
		public int Order { get; set; } = -1;

		public TestingOrderedFilterAttribute(int _order)
		{
			Order = _order;
		}
		public void OnActionExecuted(ActionExecutedContext context)
		{
			Console.WriteLine($"My order is {Order}, hence finished accordingly");
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			Console.WriteLine($"My order is {Order}, hence executed accordingly");
		}
	}
}
