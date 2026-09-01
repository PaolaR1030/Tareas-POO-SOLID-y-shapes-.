

using DemoOpenClosePrinciple;

AreaCalculator calculator = new AreaCalculator();

Circle circle1 = new Circle();
circle1.Radius = 2;

Circle circle2 = new Circle();
circle2.Radius = 3;

Circle circle3 = new Circle();
circle3.Radius = 4;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;

Square square3 = new Square();
square3.Size = 7;

Triangulo triangulo1 = new Triangulo();
triangulo1.Base = 5;
triangulo1.Altura = 2;

Triangulo triangulo2 = new Triangulo();
triangulo2.Base = 4;
triangulo2.Altura = 3;

Triangulo triangulo3= new Triangulo();
triangulo3.Base = 8;
triangulo3.Altura = 8;

Rectangulo rectangulo1= new Rectangulo();
rectangulo1.Base = 6;
rectangulo1.Altura = 8;
Rectangulo rectangulo2 = new Rectangulo();
rectangulo2.Base = 9;
rectangulo2.Altura = 6;
Rectangulo rectangulo3 = new Rectangulo();
rectangulo3.Base = 3;
rectangulo3.Altura = 5;


Pentagono pentagono1 = new Pentagono();
pentagono1.Perimetro = 9;
pentagono1.Apotema = 5;
Pentagono pentagono2 = new Pentagono();
pentagono2.Perimetro = 8;
pentagono2.Apotema = 2;
Pentagono pentagono3 = new Pentagono();
pentagono3.Perimetro = 10;
pentagono3.Apotema = 8;

List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(square3);
shapes.Add(triangulo1);
shapes.Add(triangulo2);
shapes.Add(triangulo3);
shapes.Add(rectangulo1);
shapes.Add(rectangulo2);
shapes.Add(rectangulo3);
shapes.Add(pentagono1);
shapes.Add(pentagono2);
shapes.Add(pentagono3);


var resultTotalArea = calculator.TotalArea(shapes);

Console.WriteLine($"El área total es {resultTotalArea}");