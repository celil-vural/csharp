using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObject
{
    public abstract record BookDtoForManipulation
    {
        [Required(ErrorMessage = "Title is a required field.")]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; init; }
        [Required(ErrorMessage = "Price is a required field.")]
        [Range(10, 1000)]
        public decimal Price { get; init; }
    }
}
