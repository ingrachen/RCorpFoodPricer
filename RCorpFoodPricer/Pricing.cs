namespace RCorpFoodPricer
{
    using System;

    public enum TypeOfMeal
    {
        Assiette,
        Sandwich
    }

    public enum BeverageSize
    {
        Petit,
        Moyen,
        Grand
        
    }

    public class Pricing
    {
        //calcule le prix payé par l'utilisateur dans le restaurant, en fonction de type de 
        //repas qu'il prend (assiette ou sandwich), de la taille de la boisson (petit, moyen, grand), du dessert et
        //de son type (normal ou special) et si il prend un café ou pas (yes ou no).
        //les prix sont fixes pour chaque type de chose mais des réductions peuvent s'appliquer
        //si cela rentre dans une formule!
        public double Compute(string type, string name, string beverageSize, string dessertSize, string coffee)
        {
            MealType mealType = new MealType();
            //prix total à payer pour le client
            int totalPriceToPay = 0;
            
            //le type ne peut être vide car le client doit déclarer au moins un repas
            if(string.IsNullOrEmpty(type+name)) return -1;

            

            TypeOfMeal typeOfMealEnum = mealType.GetMealType(type);
            BeverageSize beverageSizeEnum = mealType.GetBeverageSize(beverageSize);
            if (typeOfMealEnum == TypeOfMeal.Assiette)
            {
                mealType = new MealType(new Assiette());
            }
            else
            {
                mealType = new MealType(new Sandwich());
            }

            totalPriceToPay += mealType.ComputePrice(beverageSizeEnum, dessertSize);
            totalPriceToPay += mealType.WithCoffee(beverageSizeEnum, dessertSize, coffee);
            //===============================================
            //si le client prends un plat en assiette
            
            return totalPriceToPay;
        }
    }
}