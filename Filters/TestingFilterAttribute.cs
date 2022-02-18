using Microsoft.AspNetCore.Mvc.Filters;

namespace filters_tut.Controllers
{
	public class TestingFilterAttribute : Attribute, IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext context)
		{
			Console.WriteLine("Executed testing attribute filter");
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			Console.WriteLine("Executing testing attribute filter");
		}
	}
}
