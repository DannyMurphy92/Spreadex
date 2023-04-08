using Spreadex.console.models;
using Spreadex.console.services.factories.interfaces;
using Spreadex.console.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadex.console.services;
public class Application : IApplication
{
    private readonly IWidgetFactory _widgetFactory;
    private readonly IConsoleProvider _consoleProvider;
    public Application(IWidgetFactory widgetFactory, IConsoleProvider consoleProvider)
    {
        _widgetFactory = widgetFactory;
        _consoleProvider = consoleProvider;
    }

    public void Run()
    {
        var widgets = CreateWidgets();

        foreach (var widget in widgets)
        {
            _consoleProvider.WriteLine($"{widget.WidgetType} {widget.GetCoordinatesString()} {widget.GetDimensionsString()}");
        }
    }

    private IList<BaseWidget> CreateWidgets()
    {
        IList<BaseWidget> widgets = new List<BaseWidget>();
        var rectangleCoordinates = new WidgetCoordinates(10, 10);
        widgets.Add(_widgetFactory.CreateRectangle(rectangleCoordinates, 30, 40));

        var squareCoordinates = new WidgetCoordinates(15, 30);
        widgets.Add(_widgetFactory.CreateSquare(squareCoordinates, 35));

        var ellipseCoordinates = new WidgetCoordinates(100, 150);
        widgets.Add(_widgetFactory.CreateEllipse(ellipseCoordinates, 300, 200));

        var circleCoordinates = new WidgetCoordinates(1, 1);
        widgets.Add(_widgetFactory.CreateCircle(circleCoordinates, 300));

        var textboxCoordinates = new WidgetCoordinates(5, 5);
        widgets.Add(_widgetFactory.CreateTextbox(textboxCoordinates, 200, 100, "sample text"));

        return widgets;
    }
}
