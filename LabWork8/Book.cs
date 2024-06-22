namespace LabWork8
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book() : this("Собачье cердце", "М.А. Булгаков", 889) { }

        public Book(string name, string author, int price)
        {
            Name = name;
            Author = author;
            Price = price;
        }

        public override string ToString() => $"Название: {Name}, Автор: {Author}, Цена: {Price}";

        public override bool Equals(object? obj)
        {
            if (obj is Book book)
                return Name == book.Name && Author == book.Author && Price == book.Price;
            return false;
        }

    }
}
