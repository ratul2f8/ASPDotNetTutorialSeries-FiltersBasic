using Microsoft.AspNetCore.Mvc.Filters;

namespace filters_tut.Filters
{
	public class TestingAsyncFilterAttribute : Attribute,IAsyncActionFilter
	{
		public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			Console.WriteLine("Before executing async filter attribute");
			await next();
			Console.WriteLine("After executing async filter attribute");
		}
	}
}
