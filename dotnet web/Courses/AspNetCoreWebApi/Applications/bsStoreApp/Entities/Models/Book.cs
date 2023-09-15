using Entities.Abstract;

namespace Entities.Models
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
    }
}
