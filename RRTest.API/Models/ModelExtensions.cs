namespace RRTest.API.Models;

public static class ModelExtensions
{
    public static BookDTO ToBookDTO(this Book book)
    {
        return new BookDTO
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            ReleaseYear = book.ReleaseDate.Year,
            ReleaseMonth = book.ReleaseDate.Month,
            ReleaseDay = book.ReleaseDate.Day
        };
    }

    public static Book ToBook(this BookDTO bookDTO)
    {
        DateOnly releaseDate = new DateOnly(bookDTO.ReleaseMonth, bookDTO.ReleaseMonth, bookDTO.ReleaseDay);

        return new Book
        {
            Title = bookDTO.Title,
            Author = bookDTO.Author,
            ReleaseDate = releaseDate
        };
    }
}
