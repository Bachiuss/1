
using NewTry;


var person = new Person(23, "Zaza");

Console.WriteLine(person.Introduction());



var loop = new Loop();
loop.ForLoop();

var rectangle = new Rectangle(13.5, 54.6);
Console.WriteLine(rectangle.CalculateArea());

var circle = new Circle(34);
Console.WriteLine(circle.CalculateArea());


var car = new Car();
car.StartEngine();
var bicycle = new Bicycle();
bicycle.StartEngine();