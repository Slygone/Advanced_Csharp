using Task01.Domian;
using Task01.Domian.Models;
using Task01.Domian.Utils;

Circle circle1 = new Circle(5);
Circle circle2 = new Circle(10);
Circle circle3 = new Circle(15);
Rectangle rectangle1 = new Rectangle(2, 3);
Rectangle rectangle2 = new Rectangle(5, 7);
Rectangle rectangle3 = new Rectangle(13, 12);

Db<Shape> db = new Db<Shape>();

List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(rectangle1);
shapes.Add(rectangle2);
shapes.Add(rectangle3);

db.shapes = new List<Shape>(shapes);

foreach (Shape shape in db.shapes)
{
    db.PrintArea(shape);
    Helpers<Shape>.CheckType(shape);
}

