using AutoFixture;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using Spreadex.console.models;
using Spreadex.console.services;
using Spreadex.console.services.factories.interfaces;
using Spreadex.console.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Spreadex.console.tests.services;
public class ApplicationTests
{
    private readonly IWidgetFactory _widgetFactory;
    private readonly IConsoleProvider _consoleProvider;
    private readonly Application _sut;

    private IList<BaseWidget> widgets;
    private readonly Fixture _fixture;
    public ApplicationTests()
    {
        _fixture = new Fixture();
        _widgetFactory = Substitute.For<IWidgetFactory>();
        _consoleProvider = Substitute.For<IConsoleProvider>();

        SetupMockWidgets();

        _sut = new Application(_widgetFactory, _consoleProvider);
    }

    private void SetupMockWidgets()
    {
        widgets = new List<BaseWidget>();

        var rectangle = _fixture.Create<RectangleWidget>();
        var square = _fixture.Create<SquareWidget>();
        var circle = _fixture.Create<CircleWidget>();
        var ellipse = _fixture.Create<EllipseWidget>();
        var textbox = _fixture.Create<TextboxWidget>();

        _widgetFactory.CreateRectangle(default, default, default).ReturnsForAnyArgs(rectangle);
        _widgetFactory.CreateSquare(default, default).ReturnsForAnyArgs(square);
        _widgetFactory.CreateCircle(default, default).ReturnsForAnyArgs(circle);
        _widgetFactory.CreateEllipse(default, default, default).ReturnsForAnyArgs(ellipse);
        _widgetFactory.CreateTextbox(default, default, default, default).ReturnsForAnyArgs(textbox);

        widgets.Add(rectangle);
        widgets.Add(square);
        widgets.Add(circle);
        widgets.Add(ellipse);
        widgets.Add(textbox);

    }

    [Fact]
    public void Run_WhenCalled_CreatesCorrectShapes()
    {
        _sut.Run();

        _widgetFactory.Received(1).CreateRectangle(Arg.Any<WidgetCoordinates>(), Arg.Any<int>(), Arg.Any<int>());

        _widgetFactory.Received(1).CreateSquare(Arg.Any<WidgetCoordinates>(), Arg.Any<int>());

        _widgetFactory.Received(1).CreateEllipse(Arg.Any<WidgetCoordinates>(), Arg.Any<int>(), Arg.Any<int>());

        _widgetFactory.Received(1).CreateCircle(Arg.Any<WidgetCoordinates>(), Arg.Any<int>());

        _widgetFactory.Received(1).CreateTextbox(Arg.Any<WidgetCoordinates>(), Arg.Any<int>(), Arg.Any<int>(), Arg.Any<string>());    
    }

    [Fact]
    public void Run_PrintsOutAllWidgetInformation()
    {
        _sut.Run();

        _consoleProvider.Received(widgets.Count).WriteLine(Arg.Any<string>());

        foreach (var widget in widgets)
        {
            _consoleProvider.Received(1).WriteLine(($"{widget.WidgetType} {widget.GetCoordinatesString()} {widget.GetDimensionsString()}"));
        }
    }
}
