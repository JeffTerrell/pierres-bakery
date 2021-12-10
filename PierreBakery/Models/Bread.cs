namespace PierreBakery.Models
{

  public class Bread
  {
    public int BreadOrder { get; set;}
    public Bread(int orderAmount)
    {
      BreadOrder = orderAmount;
    }

    public int GetBreadTotal()
    {
      int breadOrderTotal = 0;

      if (BreadOrder == 1 || BreadOrder == 2)
      {
        breadOrderTotal += BreadOrder * 5;
      }
      return breadOrderTotal;
    }
  }
}