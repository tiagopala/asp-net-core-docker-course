using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneratorApi.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GeneratorApi.Controllers
{
    [ApiController]
    [Route("[action]")]
    [Produces("application/json")]
    public class GeneratorController : ControllerBase
    {
        private readonly IGeneratorManager _generatorManager;

        public GeneratorController(IGeneratorManager generatorManager)
        {
            _generatorManager = generatorManager;
        }


        /// <summary>
        /// Get 3 Random Names
        /// </summary>
        /// <returns>A list of 3 random names</returns>
        /// <response code="200">Returns a list with 3 random names</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IActionResult Names()
        {
            var names = _generatorManager.GetRandomNames();

            return Ok(names);
        }


        /// <summary>
        /// Get 3 Random Numbers
        /// </summary>
        /// <returns>A list of 3 random numbers</returns>
        /// /// <response code="200">Returns a list with 3 random numbers</response>
        [HttpGet]
        public IActionResult Numbers()
        {
            var numbers = _generatorManager.GetRandomNumbers();
            
            return Ok(numbers);
        }
    }
}
