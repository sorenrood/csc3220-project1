using System;
using Sack;

class project1
{
  static void Main(string[] args)
    {
      Console.WriteLine("\nInitializing Backpack.\n");
      Backpack bp = new Backpack();

      Console.WriteLine("Adding 4.3 to left pocket.");
      bp.InsertItemsInLeftPocket(4.3);

      Console.WriteLine("Adding 3.2 to main pocket.");
      bp.InsertItemsInMainPocket(3.2);

      Console.WriteLine("Adding 1.1 to right pocket.");
      bp.InsertItemsInRightPocket(1.1);

      Console.WriteLine($"\nTotal weight: {bp.GetTotalWeight()}");

      Console.WriteLine("\nRemoving 1.6 from main pocket.");
      bp.RemoveItemsFromMainPocket(1.6);
      Console.WriteLine($"\nTotal weight: {bp.GetTotalWeight()}");
    }
}
