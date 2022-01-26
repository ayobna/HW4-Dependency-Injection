using HW4_Dependency_Injection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW4_Dependency_Injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        ICalculator calculator;

        public CalculatorController(ICalculator calculator_)
        {
            calculator = calculator_;
        }

        [HttpGet]
        [Route("api/Calculator/{num1}/{num2}")]
        public int CalculatorResult(int num1, int num2)
        {
            return calculator.Add(num1, num2);
        }
    }
}
