namespace RCorpFoodPricer;

public interface IMealType
{
    int ComputePrice(BeverageSize beverageSize, string dessertSize);
}