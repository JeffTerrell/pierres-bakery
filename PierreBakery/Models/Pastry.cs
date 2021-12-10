namespace PierreBakery.Models
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    public Pastry(int orderAmount)
    {
      PastryOrder = orderAmount;
    }

    public int GetPastryTotal()
    {
      int pastryOrderTotal = 0;

      if (PastryOrder == 1 || PastryOrder == 2)
      {
        pastryOrderTotal += PastryOrder * 2;
      }
        else if (PastryOrder == 3)
        {
          pastryOrderTotal += PastryOrder + 2;
        }
        else if (PastryOrder == 4)
        {
          pastryOrderTotal += PastryOrder + 3;
        }
        else if (PastryOrder == 5)
        {
          pastryOrderTotal += PastryOrder + 4;
        }
      return pastryOrderTotal;
    }
  }
}