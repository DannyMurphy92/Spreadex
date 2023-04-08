using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadex.console.models;
public abstract class BaseWidget
{
    public BaseWidget(WidgetCoordinates coordinates)
    {
        Coordinates = coordinates;
    }
    public WidgetCoordinates Coordinates { get; }
    public abstract string WidgetType { get; }
    public string GetCoordinatesString()
    {
        return $"({Coordinates.X}, {Coordinates.Y})";
    }

    public abstract string GetDimensionsString();
}
