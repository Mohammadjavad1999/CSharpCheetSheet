namespace ClassFeatures.Inheritance;

public class Asset
{
    public virtual void Sell(decimal amount)
    {
        if (amount <= 0)
            throw new Exception("Amount is Not Acceptable");

        System.Console.WriteLine($"{amount} is Sold");
    }
    public virtual void Buy(decimal amount)
    {
        if (amount <= 0)
            throw new Exception("Amount is Not Acceptable");

        System.Console.WriteLine($"{amount} is Buied");
    }

    public virtual Asset Clone() => new Asset();
}
public class Stock : Asset
{
    public override void Sell(decimal amount)
    {
        if (amount < 1000)
            throw new Exception("it's less than Excepted");
        base.Sell(amount);
    }
    internal decimal Share => 100000;
}
public class House : Asset
{
    #region Inheritance
    public override House Clone()
    {
        return new House();
    }
    #endregion
    #region TypeCasting
    public void Upcasting()
    {
        Stock msft = new Stock();
        Asset a = msft;
    }

    public void Downcasting()
    {
        Asset asset = new Asset();
        Stock msft = (Stock)asset;
    }

    public void IsOperator()
    {
        Asset a = new Asset();
        if (a is Stock s && s.Share > 1000)
            Console.WriteLine("Stock is An Asset and It's Worth Upper Than 1000");
    }
    #endregion

}