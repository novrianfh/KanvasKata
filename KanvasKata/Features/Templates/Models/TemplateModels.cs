namespace KanvasKata.Features.Templates.Models;

public class TemplateManifest
{
    public List<TemplateItem> Templates { get; set; } = [];
}

public class TemplateItem
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Thumbnail { get; set; } = "";
    public int CanvasWidth { get; set; } = 640;
    public int CanvasHeight { get; set; } = 480;
    public List<TemplateCanvasItem> Items { get; set; } = [];
}

public class TemplateCanvasItem
{
    public string Type { get; set; } = "";
    public float X { get; set; }
    public float Y { get; set; }

    // Text
    public string? Text { get; set; }
    public string FontFamily { get; set; } = "Segoe UI";
    public int FontSize { get; set; } = 24;
    public string Align { get; set; } = "left";
    public string Color { get; set; } = "#1a1a1a";
    public int StrokeWidth { get; set; }
    public string StrokeColor { get; set; } = "#000000";

    // Image
    public string? Src { get; set; }
    public string Alt { get; set; } = "";
    public int Width { get; set; } = 240;
    public int Height { get; set; }
}
