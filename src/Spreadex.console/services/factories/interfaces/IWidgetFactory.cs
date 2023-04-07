using Spreadex.console.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadex.console.services.factories.interfaces;
public interface IWidgetFactory
{
    BaseWidget CreateRectangle(WidgetCoordinates coordinates, int width, int height);
    BaseWidget CreateSquare(WidgetCoordinates coordinates, int size);
    BaseWidget CreateEllipse(WidgetCoordinates coordinates, int horizontalDiameter, int verticalDiameter);
    BaseWidget CreateCircle(WidgetCoordinates coordinates, int size);
    BaseWidget CreateTextbox(WidgetCoordinates coordinates, int width, int height, string text);


}
