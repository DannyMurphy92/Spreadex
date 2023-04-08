using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadex.console.models;
public class TextboxWidget : RectangleWidget
{
    public TextboxWidget(WidgetCoordinates coordinates, int width, int height, string text) : base(coordinates, width, height)
    {
        Text = text;
    }

    public string Text { get; }
    public override string WidgetType => "Textbox";

    public override string GetDimensionsString()
    {
        var rectangleString = base.GetDimensionsString();
        return $"{rectangleString} text=\"{Text}\"";
    }
}
