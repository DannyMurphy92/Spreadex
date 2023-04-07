using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadex.console.models;
public class EllipseWidget:BaseWidget
{
    public EllipseWidget(WidgetCoordinates coordinates, int horizontalDiameter, int verticalDiameter) : base(coordinates)
    {
        HorizontalDiameter = horizontalDiameter;
        VerticalDiameter = verticalDiameter;
    }

    public int HorizontalDiameter { get; }
    public int VerticalDiameter { get; }

    public override string GetDimensionsString()
    {
        return $"horizontal diameter={HorizontalDiameter}, vertical diameter={VerticalDiameter}";
    }
}
