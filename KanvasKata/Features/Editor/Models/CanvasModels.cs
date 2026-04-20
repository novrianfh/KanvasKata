namespace KanvasKata.Features.Editor.Models;

public abstract class CanvasItem
{
    public Guid Id { get; } = Guid.NewGuid();
    public float X { get; set; } = 20;
    public float Y { get; set; } = 20;
}

public class TextItem : CanvasItem
{
    public string Text { get; set; } = "Teks";
    public string FontFamily { get; set; } = "Segoe UI";
    public int FontSize { get; set; } = 24;
    public string Align { get; set; } = "left";
    public string Color { get; set; } = "#1a1a1a";
    public int StrokeWidth { get; set; } = 0;
    public string StrokeColor { get; set; } = "#000000";
}

public class ImageItem : CanvasItem
{
    public string Src { get; set; } = string.Empty;
    public string Alt { get; set; } = string.Empty;
    public int Width { get; set; } = 240;
    public int Height { get; set; } = 0; // 0 = auto
}
