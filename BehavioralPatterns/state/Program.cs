using strategy;
using System.Collections.Generic;
using System;
using state.Orders;

List<Product> Products = new(){
    new Product{ProductId =1,ProductName="Mouse",Price = 100,qty = 1000},
    new Product{ProductId =2,ProductName="Laptop",Price = 15000,qty=150},
};
Inventory inventory = new();
inventory.AddBulkProducts(Products);
//Order 
OrderDecorator order = new();
if (inventory.GetProduct(new Order() { Product = Products[0], qty = 20 }) == CheckProductAvailability.Available)
    order = new()
    {
        Product = Products[1],
        qty = 1
    };
Cart cart = new();
cart.AddOrder(order);
Checkout checkout = new();
order.DraftState();
order.ConfirmationState();
order.CancelState();
Console.WriteLine(checkout.ProcessCheckout(cart));