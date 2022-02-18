using filters_tut.Filters;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace filters_tut.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestingController : ControllerBase
	{
		[HttpGet]
		public async Task<string> getHello()
		{
			return "Hello World";
		}

		[TestingFilterAttribute]
		[HttpGet("/attribute")]
		public async Task<string> getHelloAttribute()
		{
			return "Hello World";
		}

		
		[TestingAsyncFilterAttribute]
		[HttpGet("/async-attribute")]
		public async Task<string> getHelloAsyncAttribute()
		{
			return "Hello World";
		}

		
		[TestingFilterAttribute]
		[TestingAsyncFilterAttribute]
		//Lower the attribute, faster it will execute and slower it will finish
		//Tweak this value to change the execution order
		//Default is 0
		//By default, these filters will execute according to the order they are mentioned and global filters will execute first
		[TestingOrderedFilterAttribute(-1)]
		[HttpGet("/ordered")]
		public async Task<string> getHelloFromOrderedController()
		{
			return "Hello World";
		}
	}
}
