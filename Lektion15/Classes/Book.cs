namespace Lektion15.Classes
{
    public class Book : ICloneable
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Book(int id, string title) => (Id, Title) = (id, title);

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
