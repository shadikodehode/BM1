public class Prod
{
 private string name;
 private decimal price;
 private int amount;
 private decimal totalValue;   

 public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NullReferenceException();
            }
            name = value;
        }
    }
public decimal Price
    {
        get
        {
            return price;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Price cannot be negative");
            }
            price = value;
        }
    }
    public int Amount
    {
        get
        {
           return amount;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Amount cannot be negatie");
            }
            amount = value;
        }
    }
    public decimal TotalValue
    {
        get
        {
            return price * amount;
        }
    }

}