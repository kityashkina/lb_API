using Microsoft.AspNetCore.Mvc;
using MathAPI.Models;

namespace MathAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpPost("calculate")]
    public double Calculate(CalcRequest request)
    {
        // ВНИМАНИЕ: Здесь нужно подставить операцию по твоему варианту!
        // Вариант 1: Сложение
        return request.A + request.B;

        // Вариант 2: Умножение
        // return request.A * request.B;

        // Вариант 3: Деление
        // return request.A / request.B;

        // Вариант 4: Возведение в степень
        // return Math.Pow(request.A, request.B);
    }
}