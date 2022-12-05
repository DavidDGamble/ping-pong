namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Input a number: ");
      string inputVar = Console.ReadLine();
      int inputNumber = int.Parse(inputVar);
      NumberInput ping = new NumberInput(inputNumber);
      List<string> output =  ping.RunPing();
      foreach (string o in output)
      {
        Console.WriteLine(o);
      }
    }
  }
}