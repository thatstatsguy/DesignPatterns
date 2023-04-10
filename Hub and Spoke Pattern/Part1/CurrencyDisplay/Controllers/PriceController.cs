using CurrencyDisplay.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyDisplay.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PriceController : Controller
{
    [HttpPost]
    public IActionResult Update([FromBody] PriceUpdate priceUpdate)
    {
        return Ok("TODO");
    }    
}