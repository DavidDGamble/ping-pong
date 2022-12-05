namespace PingPong 
{
  public class NumberInput
  {
    public int Number { get; set; }

    public NumberInput(int number)
    {
      Number = number;
    }

    public List<string> RunPing()
    {
      List<string> numbers = new List<string> {};
      for (int index = 1; index <= Number; index++)
      {
        if (index % 3 == 0 && index % 5 == 0)
        {
          numbers.Add("ping-pong");
        }
        else if (index % 3 == 0)
        {
          numbers.Add("ping");
        }
        else if (index % 5 == 0)
        {
          numbers.Add("pong");
        }
        else
        {
          string strNum = index.ToString();
          numbers.Add(strNum);
        }
      }
      return numbers;
    }
  }
}