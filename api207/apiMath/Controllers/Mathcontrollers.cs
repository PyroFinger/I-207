using Microsoft.AspNetCore.Mvc;
namespace apiMath.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mathcontrollers : ControllerBase
    {
        Lesson1.Math clsmathService =new Lesson1.Math();
        [HttpGet("sum")]
        public int Sum(double num1, int num2) => clsmathService.sum(num1, num2);

        [HttpGet("sub")]
        public int Sub(double num1, int num2) => clsmathService.sub(num1, num2);

        [HttpGet("div")]
        public int Div(double num1, int num2) => clsmathService.div(num1, num2);

        [HttpGet("mult")]
        public int Mult(double num1, int num2) => clsmathService.mult(num1, num2);
        [HttpGet("percent")]
        public double Percent(double num1, int num2) => clsmathService.percent(num1, num2);
        [HttpGet("revpercent")]
        public double ReversePercent(double num1, int num2) => clsmathService.revpercent(num1, num2);

        [HttpGet("Factorial")]
        public int Factorial(int num1) => (int)clsmathService.factorial(num1);

        [HttpPost("max")]
        public double Max([FromQuery] double[] numbers) => clsmathService.max(numbers);

        [HttpPost("min")]
        public double Min([FromQuery] double[] numbers) => clsmathService.min(numbers);

        [HttpPost("sumar")]
        public double SumAr([FromQuery] double[] numbers) => clsmathService.sumar(numbers);

        [HttpPost("count")]
        public double Count([FromQuery] double[] numbers) => clsmathService.count(numbers);

        [HttpGet("DWR")]
        public double DWR(double num1, double num2) => clsmathService.dwr(num1, num2);
    }
}

