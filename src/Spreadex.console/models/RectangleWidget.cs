namespace Spreadex.console.models;
public class RectangleWidget: BaseWidget
{
    public RectangleWidget(WidgetCoordinates coordinates, int width, int height): base(coordinates)
    {
        Width = width;
        Height = height;
    }

    public int Width { get; }
    public int Height { get; }

    public override string GetDimensionsString()
    {
        return $"width={Width}, height={Height}";
    }
}
