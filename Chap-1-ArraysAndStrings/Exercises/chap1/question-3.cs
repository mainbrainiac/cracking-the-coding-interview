using System.Text;

namespace Code;

// 1.3 URLify: Write a method to replace all spaces in a string with '%20'.  You may assume that the string has sufficient space at the end of the string to hold the additional characters, and that you are given the "true" length of the string. (Note: if implementing in java, please use a character array so that you can perform this operation in place.)
// EXAMPLE
// Input:  "Mr John Smith    "
// Output: "Mr%20John%20Smith"

public static class Question3
{

  // Space O(?)
  // Time O(?)
  public static string Urlify(string url, int trueUrlLength)
  {
    var urlChars = url.ToCharArray();
    var result = new StringBuilder();

    if (urlChars.Length != trueUrlLength) throw new ArgumentException("Size of url must be " + trueUrlLength);

    for (var i = 0; i < urlChars.Length; i++) 
    {
      if (Char.IsWhiteSpace(urlChars[i]))
      {
        result.Append("%20");
      }
      else
      {
        result.Append(urlChars[i]);
      }
    } 

    return result.ToString();
  }
}