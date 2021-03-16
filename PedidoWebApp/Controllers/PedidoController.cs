using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PedidoWebApp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PedidoController : ControllerBase
	{

		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new[] {"Item 1", "Item 2"};
		}
	}
}