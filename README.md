# KanvasKata

Aplikasi desain canvas berbasis browser, mirip Canva versi ringan, dibangun dengan Blazor WebAssembly (.NET 10).

<img width="1920" alt="image" src="https://github.com/user-attachments/assets/178f777a-b47f-4242-994d-8d4ef0433a1e" />

## Stack

- **Framework:** Blazor WebAssembly (.NET 10)
- **Bahasa:** C# 13, Razor Components
- **Export:** html2canvas v1.4.1 (PNG)
- **Arsitektur:** Vertical Slice Architecture (VSA)
- Tidak membutuhkan backend atau database — semua state dikelola in-memory di browser

## Fitur

- **Canvas Editor** — tambah teks & gambar, drag-and-drop, resize dengan 8 handle, edit teks inline, manajemen layer (z-index)
- **Templates** — 5 template bertema Indonesia siap pakai (Fajar Baru, Samudra Jiwa, Mimpi Berbintang, Pohon Kehidupan, Cahaya Hati)
- **Export PNG** — unduh hasil desain dalam resolusi 1x atau 2x dengan nama file dari judul canvas
- **Properti dinamis** — panel properti kontekstual untuk mengatur font, warna, ukuran, dan alignment

## Struktur Project

```
KanvasKata/
├── Features/
│   ├── Editor/         # CanvasStateService, model item (Text, Image), PropertiesSidebar
│   └── Templates/      # TemplateService, model template, TemplatesSidebar
├── Pages/
│   └── Index.razor     # Halaman utama (layout 3 kolom)
└── wwwroot/
    ├── css/            # Styling aplikasi
    ├── js/             # kanvas.js (wrapper html2canvas)
    └── templates/      # templates.json + thumbnail
```

## Cara Menjalankan

```bash
dotnet run --project KanvasKata
```

Buka browser di `https://localhost:5001`.

## Build & Test

```bash
dotnet build
dotnet test
```
