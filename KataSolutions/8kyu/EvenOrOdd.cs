namespace Codewars
{
  public class EvenOdd
  {
    public string EvenOrOdd(int number)
    {
      // my solution
      if (number % 2 == 0)
        return "Even";
      return "Odd";
    }
  }
}


// another solutions
// return number % 2 == 0 ? "Even" : "Odd";

// => number%2 == 0 ? "Even": "Odd";  
