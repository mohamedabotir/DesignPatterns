﻿using facade;
var item1 = new Item();
item1.name = "potato";
item1.price = 10;
item1.qty = 50;
var item2 = new Item();
item2.name = "tomato";
item2.price = 15;
item2.qty = 70;
var item3 = new Item();
item3.name = "apple";
item3.price = 35;
item3.qty = 100;
var inventory = new inventory();
inventory.addItem(item1); inventory.addItem(item2); inventory.addItem(item3);
var basket = new basket();
basket.addToBasket(item3);
basket.addToBasket(item1);

purchaseFacade process = new();
process.PurchaseOrder(basket);
var str = new str(1);