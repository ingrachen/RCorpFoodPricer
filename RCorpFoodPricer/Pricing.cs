namespace RCorpFoodPricer
{
    using System;

    public class Pricing
    {
        
        //calcule le prix payé par l'utilisateur dans le restaurant, en fonction de type de 
        //repas qu'il prend (assiette ou sandwich), de la taille de la boisson (petit, moyen, grand), du dessert et
        //de son type (normal ou special) et si il prend un café ou pas (yes ou no).
        //les prix sont fixes pour chaque type de chose mais des réductions peuvent s'appliquer
        //si cela rentre dans une formule!
        public double Compute(string typeOfMeal, string name, string beverage, string beverageSize, string dessert, string dessertSize, string coffee)
        {
            //prix total à payer pour le client
            int totalPriceToPay = 0;
            
            //le type ne peut être vide car le client doit déclarer au moins un repas
            if(string.IsNullOrEmpty(typeOfMeal+name)) return -1;

            //si le client prends un plat en assiette
            if(typeOfMeal=="assiette")
            {
                totalPriceToPay+=15;
                //ainsi qu'une boisson de taille:
                switch(beverageSize)
                {
                    case "petit": 
                        totalPriceToPay+=2;
                        //dans ce cas, on applique la formule standard
                        if(dessertSize=="normal")
                        {
                            //pas de formule
                            //on ajoute le prix du dessert normal
                            totalPriceToPay+=2;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            totalPriceToPay+=4;
                        }
                        break;
                    //si on prends moyen
                    case "moyen": 
                        totalPriceToPay+=3;
                        //dans ce cas, on applique la formule standard
                        if(dessertSize=="normal")
                        {
                            //j'affiche la formule appliquée
                            Console.Write("Prix Formule Standard appliquée ");
                            //le prix de la formule est donc 18
                            totalPriceToPay=18;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            totalPriceToPay+=4;
                        }
                        break;
                    case "grand": 
                        totalPriceToPay+=4;
                        //dans ce cas, on applique la formule standard
                        if(dessertSize=="normal")
                        {
                            //pas de formule
                            //on ajoute le prix du dessert normal
                            totalPriceToPay+=2;
                        } else {
                            //dans ce cas on a la fomule max
                            Console.Write("Prix Formule Max appliquée ");
                            totalPriceToPay=21;
                        }
                        break;
                }
            } 
            //mode sandwich
            else {
                totalPriceToPay+=10;
                //ainsi qu'une boisson de taille:
                switch(beverageSize)
                {
                    case "petit": 
                        totalPriceToPay+=2;
                        //dans ce cas, on applique la formule standard
                        if(dessertSize=="normal")
                        {
                            //pas de formule
                            //on ajoute le prix du dessert normal
                            totalPriceToPay+=2;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            totalPriceToPay+=4;
                        }
                        break;
                    //si on prends moyen
                    case "moyen": 
                        totalPriceToPay+=3;
                        //dans ce cas, on applique la formule standard
                        if(dessertSize=="normal")
                        {
                            //j'affiche la formule appliquée
                            Console.Write("Prix Formule Standard appliquée ");
                            //le prix de la formule est donc 18
                            totalPriceToPay=13;
                        } else {
                            //sinon on rajoute le prix du dessert special
                            totalPriceToPay+=4;
                        }
                        break;
                    case "grand": 
                        totalPriceToPay+=4;
                        //dans ce cas, on applique la formule standard
                        if(dessertSize=="normal")
                        {
                            //pas de formule
                            //on ajoute le prix du dessert normal
                            totalPriceToPay+=2;
                        } else {
                            //dans ce cas on a la fomule max
                            Console.Write("Prix Formule Max appliquée ");
                            totalPriceToPay=16;
                        }
                        break;
                }
            }
            if(typeOfMeal=="assiette" && beverageSize=="moyen" && dessertSize=="normal" && coffee=="yes")
            {
                Console.Write(" avec café offert!");
            } else {
                totalPriceToPay+=1;
            }
            return totalPriceToPay;
        }
    }
}