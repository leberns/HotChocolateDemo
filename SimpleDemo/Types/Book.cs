
namespace Demo.Types;

public class Book
{
  public string Title { get; set; }
  public string Subtitle { get; set; }
  public int YearFirstPublication { get; set; }
  public DateTime DateFirstLaunch { get; set; }
  public double Price { get; set; }
  public double Price2 { get; set; }
  public double Price3 { get; set; }
  public double Price4 { get; set; }
  public double Price5 { get; set; }

  public Author Author { get; set; }
}

public class Author
{
  public string Name { get; set; }
}