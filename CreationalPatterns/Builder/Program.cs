using Builder;

//Builder Pattern alt+s
Director director = new Director();
IBuilder milk = new Milk();
director.Construct(milk);
milk.ShowComponents();

var input = Console.ReadLine();

Console.WriteLine(5/int.Parse(input));
