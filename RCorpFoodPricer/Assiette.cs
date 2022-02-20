using System.Diagnostics.CodeAnalysis;

namespace RCorpFoodPricer;

public class Assiette: IMealType
{
    private int totalPrice= 15 ;

    public int ComputePrice(BeverageSize beverageSize, string dessertSize)
    {
        if (beverageSize == BeverageSize.Grand && dessertSize != "normal")
        {
            Console.Write("Prix Formule Max appliquée ");
            totalPrice = 21;
        }
        else
        {
            if (beverageSize == BeverageSize.Moyen && dessertSize == "normal")
            {
                Console.Write("Prix Formule Standard appliquée ");
                totalPrice = 18;
            }
            else
            {
                withDrink(beverageSize);
                withDessert(dessertSize);
            }
        }

        return totalPrice;
    }
    public void withDrink(BeverageSize drinkSizeEnum)
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

    public void withDessert(string dessertSize)
    {
        if (dessertSize == "normal")
        {
            totalPrice += 2;
        }
        
        totalPrice += 4;
    }
}