using Demo.Types;

namespace Demo.Queries;

public class BookQuery
{
  public Book GetBook() =>
      new Book
      {
        Title = "C# in depth.",
        Subtitle = "Testing",
        YearFirstPublication = 2001,
        DateFirstLaunch = new DateTime(2001, 02, 10, 09, 30, 00),
        Price = 1.00000001,
        Price2 = 1.00000002,
        Price3 = 1.00000003,
        Price4 = 1.00000004,
        Price5 = 1.00000005,
        Author = new Author
        {
          Name = "Jon Skeet"
        }
      };
}