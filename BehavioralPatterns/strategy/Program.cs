using strategy;
using System.Collections.Generic;
using System;
List<Product> Products = new(){
    new Product{ProductId =1,ProductName="Mouse",Price = 10_0M,qty = 1000},
    new Product{ProductId =2,ProductName="Laptop",Price = 15_000M,qty=150},
};
Inventory inventory = new();
inventory.AddBulkProducts(Products);

Order order = new();
if (inventory.GetProduct(new Order() { Product = Products[0], qty = 20 }) == CheckProductAvailability.Available)
    order = new()
    {
        Product = Products[0],
        qty = 1
    };
Cart cart = new();
cart.AddOrder(order);
cart.AddOrder(order);
Checkout checkout = new();
Console.WriteLine(checkout.ProcessCheckout(cart));
