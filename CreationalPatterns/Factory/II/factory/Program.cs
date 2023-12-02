using Autofac;
using factory.abstractFactory;
using factory.deligationFactoryToSolveInput;
using static factory.deligationFactoryToSolveInput.Invoice;
using static factory.Point.Point;
var cartesian = CoordinateFactory.CreateCartesianSystem(5, 2);
var polar = CoordinateFactory.CreatePolarSystem(5, 2);
Console.WriteLine(cartesian);
Console.WriteLine(polar);

#region abstract client
ShapeFactory.GetShapeType(false)
.CreateShape(Shape.Square)
.Draw();
#endregion

#region inject service using delegate
var container = new ContainerBuilder();
container.RegisterType<EmailService>();
container.RegisterType<InvoiceFactory>();

var containerBuilder = container.Build();
var invoiceFactoryResolver = containerBuilder.Resolve<InvoiceFactory.InvokeInvoice>();
var factory = invoiceFactoryResolver(20);
factory.calculateTotal();

#endregion