namespace RRTest.API.Models;

public class BookDTO
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public int ReleaseYear { get; set; }
    public int ReleaseMonth { get; set; }
    public int ReleaseDay { get; set; }
}
