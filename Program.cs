using System.Diagnostics.CodeAnalysis;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
SetDateFormat("dd-MM-yyyy"); // When type inside "" it will get the format of date suggestion
                             // from StringSyntaxAttribute.DateTimeFormat as IntelliSense in VS 
RegexFormat("[a]");

UriFormat("");
internal partial class Program
{
    public static void SetDateFormat(
        [StringSyntax(StringSyntaxAttribute.DateTimeFormat)] string dateformat
        )
    {
        //code

    }

    public static void RegexFormat(
       [StringSyntax(StringSyntaxAttribute.Regex)] string dateformat
       )
    {
        //code

    }


    public static void UriFormat(
      [StringSyntax(StringSyntaxAttribute.Uri)] string dateformat
      )
    {
        //code

    }

}
