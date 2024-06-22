namespace LabWork8
{
    abstract class Figure
    {
        public abstract void GetArea();

        public abstract void GetPerimeter();

        public abstract void GetInformation();

        public abstract string GetName { get; set; }
    }
    internal class Square : Figure
    {
        public string name;
        public double length;

        public override string GetName { get; set; }

        public override void GetArea() 
        {
            Console.WriteLine($"Площадь квадрата: {length * length}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"Периметр квадрата: {length * 4}");
        }

        public override void GetInformation()
        {
            Console.WriteLine($"Название фигуры: {GetName}, Длина фигуры: {length}, Ширина фигуры: {length}");
        }

        public Square() : this("Квадрат", 4, "") { }

        public Square(string name, double length, string getName)
        {
            GetName = name;   
            this.length = length;
        }
    }

}
