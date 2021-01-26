namespace Sack
{
  /// A structure to represent a backpack with 3 pockets. 
  class Backpack 
  {
    /// Stores the weight of the main pocket.
    private double mainPocketWeight;
    /// Stores the weight of the left pocket.
    private double leftPocketWeight;
    /// Stores the weight of the right pocket. 
    private double rightPocketWeight;
    
    /// Inserts items in the main pocket if able.
    /// ### Inputs
    /// 
    /// - 'weight' - The weight of an object as a double. 
    ///
    /// ### Returns
    ///
    /// - Boolean
    public bool InsertItemsInMainPocket(double weight) 
    {
      if (weight + this.mainPocketWeight <= 10)
      {
        this.mainPocketWeight += weight;
        return true;
      } 
      else 
      {
        return false;
      }
    }

    /// Inserts items in the right pocket if able. 
    /// ### Inputs
    /// 
    /// - 'weight' - The weight of an object as a double. 
    ///
    /// ### Returns
    ///
    /// - Boolean
    public bool InsertItemsInRightPocket(double weight)
    {
      if (this.rightPocketWeight + weight <= 5) 
      {
        this.rightPocketWeight += weight;
        return true;
      }
      else 
      {
        return false;
      }
    }
    
    /// Inserts items in the left pocket if able. 
    /// ### Inputs
    /// 
    /// - 'weight' - The weight of an object as a double. 
    ///
    /// ### Returns
    ///
    /// - Boolean
    public bool InsertItemsInLeftPocket(double weight)
    {
      if (this.leftPocketWeight + weight <= 5) 
      {
        this.leftPocketWeight += weight;
        return true;
      }
      else 
      {
        return false;
      }
    }

    /// Removes items in the main pocket if able. 
    /// ### Inputs
    /// 
    /// - 'weight' - The weight of an object as a double. 
    ///
    /// ### Returns
    ///
    /// - Boolean
    public bool RemoveItemsFromMainPocket(double weight)
    {
      if (this.mainPocketWeight - weight < 0)
      {
        return false;
      }
      else
      {
        this.mainPocketWeight -= weight;
        return true;
      }
    }

    /// Gets the weight of the backpack.
    /// ### Inputs
    ///
    /// ### Returns
    ///
    /// - Double
    public double GetTotalWeight()
    {
      return (this.mainPocketWeight + this.rightPocketWeight + this.leftPocketWeight);
    }
  }
}