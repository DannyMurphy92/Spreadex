namespace Spreadex.console.models;
public class SquareWidget: BaseWidget
{
    public SquareWidget(WidgetCoordinates coordinates, int size): base(coordinates)
    {
        Size = size;
    }

    public int Size { get; }
    public override string WidgetType => "Square";

    public override string GetDimensionsString()
    {
        return $"size={Size}";
    }
}
