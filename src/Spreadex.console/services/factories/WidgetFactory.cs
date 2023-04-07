using Spreadex.console.models;
using Spreadex.console.services.factories.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadex.console.services.factories;
public class WidgetFactory : IWidgetFactory
{
    public BaseWidget CreateRectangle(WidgetCoordinates coordinates, int width, int height)
    {
        return new RectangleWidget(coordinates, width, height);
    }

    public BaseWidget CreateSquare(WidgetCoordinates coordinates, int size)
    {
        return new SquareWidget(coordinates, size);
    }

    public BaseWidget CreateEllipse(WidgetCoordinates coordinates, int horizontalDiameter, int verticalDiameter)
    {
        return new EllipseWidget(coordinates, horizontalDiameter, verticalDiameter);
    }

    public BaseWidget CreateCircle(WidgetCoordinates coordinates, int size)
    {
        return new CircleWidget(coordinates, size);
    }

    public BaseWidget CreateTextbox(WidgetCoordinates coordinates, int width, int height, string text)
    {
        return new TextboxWidget(coordinates, width, height, text);
    }
}
