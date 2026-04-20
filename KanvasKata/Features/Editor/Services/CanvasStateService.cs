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

    public void BringForward(CanvasItem item)
    {
        var i = _items.IndexOf(item);
        if (i < _items.Count - 1)
            (_items[i], _items[i + 1]) = (_items[i + 1], _items[i]);
        OnChange?.Invoke();
    }

    public void SendBackward(CanvasItem item)
    {
        var i = _items.IndexOf(item);
        if (i > 0)
            (_items[i], _items[i - 1]) = (_items[i - 1], _items[i]);
        OnChange?.Invoke();
    }

    public void BringToFront(CanvasItem item)
    {
        _items.Remove(item);
        _items.Add(item);
        OnChange?.Invoke();
    }

    public void SendToBack(CanvasItem item)
    {
        _items.Remove(item);
        _items.Insert(0, item);
        OnChange?.Invoke();
    }

    public int IndexOf(CanvasItem item) => _items.IndexOf(item);

    public void NotifyChange() => OnChange?.Invoke();
}
