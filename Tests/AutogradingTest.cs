namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Assign_2147483647_To_A_Class_Level_Variable_Named_MaxInteger(){
        var precision = new Precision();
        Assert.Equal(2147483647, precision.MaxInteger);
    }

    [Fact]
    public void Should_Assign_The_Product_Of_2_Point_5_Multiplied_By_5_Point_75_To_A_Class_Level_Variable_Named_DecimalProduct(){
       var precision = new Precision();
        Assert.Equal(14.5986601200044m, precision.DecimalProduct);
    }
}