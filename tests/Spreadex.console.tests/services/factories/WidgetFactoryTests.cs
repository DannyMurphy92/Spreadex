using Spreadex.console.models;
using Spreadex.console.services.factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Spreadex.console.tests.services.factories;

public class WidgetFactoryTests
{
    private readonly WidgetFactory _sut;
    public WidgetFactoryTests()
    {
        _sut = new WidgetFactory();
    }

    [Fact]
    public void GivenCreateRectangleWithSpecificDimensionsAndLocation_ReturnsRectangleWithCorrectInfo()
    {
        var coordinates = new WidgetCoordinates(3, 5);
        var width = 30;
        var height = 40;

        var expectedCoordinatesOutput = "x=3, y=5";
        var expectedDimensionsString = "width=30, height=40";

        var result = _sut.CreateRectangle(coordinates, width, height);

        Assert.IsType<RectangleWidget>(result);
        Assert.Equal(expectedCoordinatesOutput, result.GetCoordinatesString());
        Assert.Equal(expectedDimensionsString, result.GetDimensionsString());
    }
}
