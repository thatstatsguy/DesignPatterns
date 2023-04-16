using CurrencyDisplay.DTO;
using CurrencyDisplay.Interfaces;
using CurrencyDisplay.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyDisplay.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PriceController : Controller
{
    private readonly IMediator _mediator;
    public PriceController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public IActionResult Update([FromBody] PriceUpdate priceUpdate)
    {
        _mediator.Publish(priceUpdate);
        return Ok("Price Update Processed");
    }    
}