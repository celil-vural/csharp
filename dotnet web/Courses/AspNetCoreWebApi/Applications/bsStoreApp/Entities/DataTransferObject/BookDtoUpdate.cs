using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObject
{
    public record BookDtoUpdate : BookDtoForManipulation
    {
        [Required]
        public int Id { get; init; }
    }

    /*{
        public int Id { get; init; }
        public string? Title { get; init; }
        public decimal Price { get; init; }
    }*/
}
