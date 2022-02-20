using Xunit;
using System;
using System.IO;
using NFluent;
using RCorpFoodPricer;


namespace RCorpFoodPricerTest;

public class Tests
{
    [Fact]
    public void SampleData_on_plus_on_numbers_txt()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);
        Console.SetError(writer);
        Program.Main(new string[] {"assiette", "couscous", "coca", "moyen", "baba", "normal", "yes"});
        var sut = writer.ToString();
        Check.That(sut).IsEqualTo(
            @$"Prix Formule Standard appliquée  avec café offert!Prix à payer : 18€
"
        );
    }
}