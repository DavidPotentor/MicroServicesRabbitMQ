﻿using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;


        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }


        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }
    }
}
