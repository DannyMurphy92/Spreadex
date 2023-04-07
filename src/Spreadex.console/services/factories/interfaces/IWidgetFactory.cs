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
}
