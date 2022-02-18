using Microsoft.AspNetCore.Mvc.Filters;

namespace filters_tut.Filters
{
	public class TestingFilter : IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext context)
		{
			Console.WriteLine("After");
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			Console.WriteLine("Before");
		}
	}
}
