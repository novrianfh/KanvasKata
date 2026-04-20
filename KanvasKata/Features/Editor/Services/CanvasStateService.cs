using KanvasKata.Features.Editor.Models;

namespace KanvasKata.Features.Editor.Services;

public class CanvasStateService
{
    private readonly List<CanvasItem> _items =
    [
        new ImageItem { Src = "https://picsum.photos/seed/kanvaskata/800/600", Alt = "KanvasKata" },
        new TextItem { ItemType = CanvasItemType.Title, Text = "KanvasKata", FontSize = 40, FontFamily = "Segoe UI", Color = "#1a1a1a", Align = "center" },
        new TextItem { ItemType = CanvasItemType.Subtitle, Text = "Ekspresikan ide, cerita, dan kreativitasmu dalam satu kanvas.", FontSize = 18, FontFamily = "Segoe UI", Color = "#555555", Align = "center" },
    ];

    public IReadOnlyList<CanvasItem> Items => _items;
    public CanvasItem? SelectedItem { get; private set; }
    public event Action? OnChange;

    public void SelectItem(CanvasItem? item)
    {
        SelectedItem = item;
        OnChange?.Invoke();
    }

    public void NotifyChange() => OnChange?.Invoke();
}
