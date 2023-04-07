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

    public string GetCoordinatesString()
    {
        return $"x={Coordinates.X}, y={Coordinates.Y}";
    }

    public abstract string GetDimensionsString();
}
