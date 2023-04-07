using Spreadex.console.models;
using Spreadex.console.services.factories.interfaces;
using System;
using System.Collections.Generic;
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
}
