using System;

namespace ProjetoDio
{
  public class Program
  {
    static int Adicionar20(int x)
    {
      return x + 20;
    }
    public static void Main()
    {
      int a = 2;
      a = Adicionar20(a); // a substituido por adicionar20 em a
      Console.WriteLine($"O valor da variavel é {a}");
    }

  }
}