// See https://aka.ms/new-console-template for more information

using Abstract_Factory.Classes;
using Abstract_Factory.Factories;

Console.WriteLine("Hello, World!");


var shoppingCart = new ShoppingCart(new BelgiumShoppingCartPurchaseFactory());

shoppingCart.CalculateCosts();