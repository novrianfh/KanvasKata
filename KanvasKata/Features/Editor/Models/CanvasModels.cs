namespace KanvasKata.Features.Editor.Models;

public enum CanvasItemType { Title, Subtitle, Image }

public abstract class CanvasItem
{
    public Guid Id { get; } = Guid.NewGuid();
    public abstract CanvasItemType Type { get; }
}

public class TextItem : CanvasItem
{
    public required CanvasItemType ItemType { get; init; }
    public override CanvasItemType Type => ItemType;
    public string Text { get; set; } = string.Empty;
    public string FontFamily { get; set; } = "Segoe UI";
    public int FontSize { get; set; } = 24;
    public string Align { get; set; } = "center";
    public string Color { get; set; } = "#1a1a1a";
    public int StrokeWidth { get; set; } = 0;
    public string StrokeColor { get; set; } = "#000000";
}

public class ImageItem : CanvasItem
{
    public override CanvasItemType Type => CanvasItemType.Image;
    public string Src { get; set; } = string.Empty;
    public string Alt { get; set; } = string.Empty;
}
