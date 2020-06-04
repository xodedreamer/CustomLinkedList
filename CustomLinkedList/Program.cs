using System;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            JList<string[]> data = new JList<string[]>() {
               new string[] {"A", "B", "C"},
               new string[] {"1", "2"},
               new string[] {"x", "yyyy", "zzz", "final"},
             };

             foreach (var array in data)
             {
                 Console.WriteLine();

                  foreach (var item in array)
                   {
                      Console.Write(" ");
                      Console.Write(item);
                   }
             }
        }
    }
}
