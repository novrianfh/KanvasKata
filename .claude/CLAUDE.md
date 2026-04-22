# KanvasKata Solution

## Stack
- dotnet versi 10
- Solution format: slnx

## Build Commands
dotnet build
dotnet test
dotnet run --project KanvasKata

## Conventions
- Vertical Slice Architecture (VSA)

## Project Structure

```
KanvasKata/                          # Solution root
├── KanvasKata.slnx                  # Solution file
├── README.md
├── .claude/
│   └── CLAUDE.md                    # Project instructions
└── KanvasKata/                      # Blazor WebAssembly project
    ├── KanvasKata.csproj
    ├── Program.cs
    ├── App.razor
    ├── MainLayout.razor
    ├── _Imports.razor
    ├── Features/                    # VSA feature slices
    │   ├── Editor/
    │   │   ├── Components/
    │   │   │   └── PropertiesSidebar.razor
    │   │   ├── Models/
    │   │   │   └── CanvasModels.cs
    │   │   └── Services/
    │   │       └── CanvasStateService.cs
    │   └── Templates/
    │       ├── Components/
    │       │   └── TemplatesSidebar.razor
    │       ├── Models/
    │       │   └── TemplateModels.cs
    │       └── Services/
    │           └── TemplateService.cs
    ├── Pages/
    │   └── Index.razor
    ├── Properties/
    │   └── launchSettings.json
    └── wwwroot/
        ├── index.html
        ├── css/
        │   └── app.css
        ├── js/
        │   └── kanvas.js
        └── templates/
            └── templates.json
```

> Update bagian ini setiap kali ada perubahan struktur folder.