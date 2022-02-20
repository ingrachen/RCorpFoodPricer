namespace RCorpFoodPricer;

public class Sandwich: IMealType
{
    private int totalPrice = 10;

    public int ComputePrice(BeverageSize beverageSize, string dessertSize)
    {
        if (beverageSize == BeverageSize.Grand && dessertSize != "normal")
        {
            Console.Write("Prix Formule Max appliquée ");
            totalPrice = 16;
        }
        else if (beverageSize == BeverageSize.Moyen && dessertSize == "normal")
        {
            Console.Write("Prix Formule Standard appliquée ");
            totalPrice = 13;
        }
        else
        {
            WithDrink(beverageSize);
            WithDessert(dessertSize);

        }

        return totalPrice;

    }
    
    public void WithDrink(BeverageSize drinkSizeEnum)
    {
        if (drinkSizeEnum == BeverageSize.Petit)
        {
            totalPrice += 2;
        }
        else if (drinkSizeEnum == BeverageSize.Moyen)
        {
            totalPrice += 3;
        }
        else
        {
            totalPrice += 4;
        }
    }

    public void WithDessert(string dessertSize)
    {
        if (dessertSize == "normal")
        {
            totalPrice += 2;
        }
        
        totalPrice += 4;
    }
    
}