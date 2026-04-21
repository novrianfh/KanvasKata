using System.Net.Http.Json;
using KanvasKata.Features.Templates.Models;

namespace KanvasKata.Features.Templates.Services;

public class TemplateService(HttpClient http)
{
    private List<TemplateItem>? _cache;

    public async Task<List<TemplateItem>> GetTemplatesAsync()
    {
        if (_cache is not null) return _cache;
        var manifest = await http.GetFromJsonAsync<TemplateManifest>("templates/templates.json");
        _cache = manifest?.Templates ?? [];
        return _cache;
    }
}
