﻿/*
 * CalculatorAPI
 *
 * CalculatorAPI
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using CalculatorApi.Models;
using CalculatorApi.Attributes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;

namespace CalculatorApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class AuthorizationApiController : ControllerBase
    {
        private readonly CalculatorApi.Services.IAuthorizationService _authorizationService;

        public AuthorizationApiController(CalculatorApi.Services.IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }



        /// <summary>
        /// Generate JWT Bearer Token
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="0">Unexpected error</response>
        [HttpPost]
        [Route("/authorization/token")]
        [AllowAnonymous]
        [ValidateModelState]
        [SwaggerOperation("AuthorizationTokenPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(AutenticationResponce), description: "Successful operation")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "Unexpected error")]
        public virtual IActionResult AuthorizationTokenPost([FromBody] AutenticationRequest body)
        {
            var token = _authorizationService.AuthorizationToken(body);

            if (token == null || token == string.Empty)
            {
                return BadRequest(new Error { Code=401,Message= "AuthenticationValue is incorrect" });
            }

            AutenticationResponce result = new AutenticationResponce() { Token = token };

            return new ObjectResult(result);
        }
    }
}
