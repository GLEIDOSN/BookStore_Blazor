using BookStore.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "Enter the title of the book.")]
        [StringLength(100)]
        public string? Title{ get; set; }

        [Required(ErrorMessage = "Enter the author of the book.")]
        [StringLength(200)]
        public string? Author { get; set; }

        [Required(ErrorMessage = "Enter the book's release date.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Enter the cover of the book.")]
        [StringLength(200)]
        public string? BookCover { get; set; }

        [Required]
        [EnumDataType(typeof(PublishingCompany), ErrorMessage = "Select the publisher Company.")]
        public PublishingCompany PublishingCompany { get; set; }

        [Required]
        [EnumDataType(typeof(Category), ErrorMessage = "Select the category.")]
        public Category category { get; set; }

        public Book(int BookId, string? title, string? author, DateTime releaseDate, string? bookCover,
            PublishingCompany publishingCompany, Category category)
        {
            this.BookId = BookId;
            Title = title;
            Author = author;
            this.ReleaseDate = releaseDate;
            BookCover = bookCover;
            PublishingCompany = publishingCompany;
            this.category= category;
        }
    }
}
