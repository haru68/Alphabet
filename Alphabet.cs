using System;

class MainClass {
  public static void Main (string[] args) {
    char CaracEntre = (char) Console.ReadKey().KeyChar;
    Console.WriteLine(Char.ToLower(CaracEntre));
  }
}