using Builder;
Director director = new Director();
IBuilder milk = new Milk();
director.Construct(milk);
milk.ShowComponents();
