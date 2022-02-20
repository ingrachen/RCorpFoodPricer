namespace RCorpFoodPricer;

public class MealType
{
    private IMealType _mealType;

    public MealType(){}
    
    public MealType(IMealType mealType)
    {
        _mealType = mealType;
    }

    public int ComputePrice(BeverageSize beverageSize, string dessertSize)
    {
        return _mealType.ComputePrice(beverageSize, dessertSize);
    }

    public int WithCoffee(BeverageSize beverageSize, string dessertSize, string coffee)
    {
        int totalPrice = 0;
        if (beverageSize == BeverageSize.Moyen && dessertSize == "normal" && coffee == "yes")
        {
            Console.Write(" avec café offert!");
        }
        else
        {
            totalPrice += 1;
        }

        return totalPrice;
    }

    public TypeOfMeal GetMealType(string type)
    {
        if (type == "sandwich")
        {
            return TypeOfMeal.Sandwich;
        }

        return TypeOfMeal.Assiette;
    }

    public BeverageSize GetBeverageSize(string size)
    {
        if (size == "petit")
        {
            return BeverageSize.Petit;
        }

        if (size == "moyen")
        {
            return BeverageSize.Moyen;
        }

        return BeverageSize.Grand;

    }

}