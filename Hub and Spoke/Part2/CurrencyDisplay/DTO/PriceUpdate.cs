using CurrencyDisplay.Interfaces;

namespace CurrencyDisplay.DTO;

/// <summary>
/// Represents a price update for a given currency conversion e.g. ZAR -> USD 
/// </summary>
/// <param name="FromCurrency">The currency being exchanged e.g. ZAR</param>
/// <param name="ToCurrency">The currency being converted to e.g. USD</param>
/// <param name="ExchangeRate">The amount of the target currency received for each "unit" of the original currency.</param>
public record PriceUpdate(string FromCurrency, string ToCurrency, double ExchangeRate) : IUiBusEvent;