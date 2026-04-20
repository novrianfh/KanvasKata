using KanvasKata.Features.Editor.Models;

namespace KanvasKata.Features.Editor.Services;

public class CanvasStateService
{
    private readonly List<CanvasItem> _items = [];

    public IReadOnlyList<CanvasItem> Items => _items;
    public CanvasItem? SelectedItem { get; private set; }
    public event Action? OnChange;

    public void AddItem(CanvasItem item)
    {
        _items.Add(item);
        SelectedItem = item;
        OnChange?.Invoke();
    }

    public void RemoveItem(CanvasItem item)
    {
        _items.Remove(item);
        if (SelectedItem?.Id == item.Id)
            SelectedItem = null;
        OnChange?.Invoke();
    }

    public void SelectItem(CanvasItem? item)
    {
        SelectedItem = item;
        OnChange?.Invoke();
    }

    public void NotifyChange() => OnChange?.Invoke();
}
