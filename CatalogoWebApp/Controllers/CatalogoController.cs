using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoWebApp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CatalogoController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new[] {"Catalogo 1", "Catalogo 2"};
		}
	}
}
