using CurrencyDisplay.DTO;
using CurrencyDisplay.Interfaces;
using CurrencyDisplay.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyDisplay.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PriceController : Controller
{
    private readonly IUiBus _eventBus;
    public PriceController(IUiBus eventBus)
    {
        _eventBus = eventBus;
    }
    [HttpPost]
    public IActionResult Update([FromBody] PriceUpdate priceUpdate)
    {
        _eventBus.Notify(priceUpdate);
        return Ok("Price Update Processed");
    }    
}