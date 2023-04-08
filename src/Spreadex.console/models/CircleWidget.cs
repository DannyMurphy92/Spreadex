using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadex.console.models;
public class CircleWidget:BaseWidget
{
    public CircleWidget(WidgetCoordinates coordinates, int size) : base(coordinates)
    {
        Size = size;
    }

    public int Size { get; }

    public override string WidgetType => "Circle";

    public override string GetDimensionsString()
    {
        return $"size={Size}";
    }
}
