﻿using DevFreela.API.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
	[Route("api/users")]
	public class UsersController : ControllerBase
	{
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return Ok();
		}
		[HttpPost]
		public IActionResult Post([FromBody] CreateUserModel createUser)
		{
			return CreatedAtAction(nameof(GetById), new { id = 1}, createUser);
		}

		[HttpPut("{id}/Login")]

		public IActionResult Login(int id, [FromBody] LoginModel loginModel)
		{
			return NoContent();
		}

	}
}
