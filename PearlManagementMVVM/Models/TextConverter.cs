namespace PearlManagementMVVM.Models
{
  using System;

  public class TextConverter
  {
    private readonly Func<string, string> conversion;

    public TextConverter(Func<string, string> conversion)
    {
      this.conversion = conversion;
    }

    public string ConvertText(string inputText)
    {
      return conversion(inputText);
    }
  }
}
