namespace PierreBakery.Models
{

  public class Bread
  {
    public int BreadOrder { get; set;}
    public Bread(int orderAmount)
    {
      BreadOrder = orderAmount;
    }
  }
}