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
    public void CreateRectangle_GivenSpecificDimensionsAndLocation_ReturnsRectangleWithCorrectInfo()
    {
        var coordinates = new WidgetCoordinates(3, 5);
        var width = 30;
        var height = 40;

        var expectedCoordinatesOutput = "(3, 5)";
        var expectedDimensionsString = "width=30 height=40";

        var result = _sut.CreateRectangle(coordinates, width, height);

        Assert.IsType<RectangleWidget>(result);
        Assert.Equal(expectedCoordinatesOutput, result.GetCoordinatesString());
        Assert.Equal(expectedDimensionsString, result.GetDimensionsString());
    }

    [Fact]
    public void CreateSquare_GivenSpecificDimensionsAndLocation_ReturnsSquareWithCorrectInfo()
    {
        var coordinates = new WidgetCoordinates(3, 5);
        var size = 30;

        var expectedCoordinatesOutput = "(3, 5)";
        var expectedDimensionsString = "size=30";

        var result = _sut.CreateSquare(coordinates, size);

        Assert.IsType<SquareWidget>(result);
        Assert.Equal(expectedCoordinatesOutput, result.GetCoordinatesString());
        Assert.Equal(expectedDimensionsString, result.GetDimensionsString());
    }

    [Fact]
    public void CreateEllipse_GivenSpecificDimensionsAndLocation_ReturnsEllipseWithCorrectInfo()
    {
        var coordinates = new WidgetCoordinates(3, 5);
        var horizontalDiameter = 30;
        var verticalDiameter = 50;

        var expectedCoordinatesOutput = "(3, 5)";
        var expectedDimensionsString = "diameterH=30 diameterV=50";

        var result = _sut.CreateEllipse(coordinates, horizontalDiameter, verticalDiameter);

        Assert.IsType<EllipseWidget>(result);
        Assert.Equal(expectedCoordinatesOutput, result.GetCoordinatesString());
        Assert.Equal(expectedDimensionsString, result.GetDimensionsString());
    }

    [Fact]
    public void CreateCircle_GivenSpecificDimensionsAndLocation_ReturnsCircleWithCorrectInfo()
    {
        var coordinates = new WidgetCoordinates(3, 5);
        var size = 30;

        var expectedCoordinatesOutput = "(3, 5)";
        var expectedDimensionsString = "size=30";

        var result = _sut.CreateCircle(coordinates, size);

        Assert.IsType<CircleWidget>(result);
        Assert.Equal(expectedCoordinatesOutput, result.GetCoordinatesString());
        Assert.Equal(expectedDimensionsString, result.GetDimensionsString());
    }

    [Fact]
    public void CreateTextbox_GivenSpecificDimensionsAndLocation_ReturnsTextboxWithCorrectInfo()
    {
        var coordinates = new WidgetCoordinates(3, 5);
        var width = 30;
        var height = 40;
        var inputString = "test string";

        var expectedCoordinatesOutput = "(3, 5)";
        var expectedDimensionsString = "width=30 height=40 text=\"test string\"";

        var result = _sut.CreateTextbox(coordinates, width, height, inputString);

        Assert.IsType<TextboxWidget>(result);
        Assert.Equal(expectedCoordinatesOutput, result.GetCoordinatesString());
        Assert.Equal(expectedDimensionsString, result.GetDimensionsString());
    }

}
