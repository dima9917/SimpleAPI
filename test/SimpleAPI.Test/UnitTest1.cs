using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController(null);

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("1", returnValue);
        // Given
    
        // When
    
        // Then
    }
    [Fact]
    public void Test1()
    {

    }
}