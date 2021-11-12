class StringArrayTest
{
  public static void Main()
  {
    string[] name = new string[3]{ "Vallabh", "Raj", "Jay"};
    
    for(int i=0;i<name.Length;i++)
    {
      System.Console.WriteLine(name[i]);
    }
  }
}