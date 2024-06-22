using LabWork8;

Book book1 = new Book();
Console.WriteLine(book1);
Console.WriteLine(book1.ToString());

Book book2 = new() { Price = 134 };
if (book1.Equals(book2))
    Console.WriteLine("Объекты одинаковые");
else
    Console.WriteLine("Объекты разные");

Console.WriteLine("\n");

Square square = new Square();
square.GetArea();
square.GetPerimeter();
square.GetInformation();