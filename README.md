# 💊 Pharmacy Sticker Printing System

A Windows Forms desktop application designed for pharmacies to generate and print customized dosage instruction stickers. It supports dynamic layouts, barcode generation, and smart input handling to ensure accurate, readable, and professional sticker output.

## 📌 Features

### 🖨️ Sticker Printing
- Print-ready layout using the `PrintDocument` class.
- Utilizes GDI+ for accurate positioning and rendering.
- Real-time sticker preview within the app.

### ✏️ Custom Text & Presets
- Add dosage instructions manually or via dropdowns:
  - Dosage
  - Timing
  - Duration
  - Frequency
- Auto-formats and appends selections to a single text block.

### 📏 Text Fitting Logic
- Dynamically measures text size to fit within sticker dimensions.
- Prevents overflow using auto-truncation.
- Ensures all printed content stays within visible boundaries.

### 🖼️ Logo Support
- Adds a centered pharmacy logo on the sticker.
- Configurable size and placement.


### 🧠 Smart Layout & Centering
- All content (logo, text, barcode) is centered both vertically and horizontally.
- Prevents misalignment during printing.

### 📝 Input Validation
- Limits custom text box input to fit within the printable area.
- Uses `Graphics.MeasureString` to enforce fitting logic in real-time.

## 🧰 Technologies Used

- **C# / .NET Framework**
- **Windows Forms (WinForms)**
- **GDI+** (System.Drawing) for rendering
- **ZXing.Net** for barcode creation

## 🗂️ Folder Structure
/DosagePrinter │ ├── Form1.cs # Main UI logic and printing code ├── StickerInfo.cs # Data model for sticker entries ├── Program.cs # App entry point ├── /Resources # App assets like logos and icons └── /bin # Compiled application output

## 📷 Screenshots



## ✅ Future Improvements

- Batch printing for multiple stickers
- Preset management and customization
- Database integration for history and logs
- Multi-size sticker templates
- Multi-language support
-  Barcode Integration
- Uses ZXing.Net to generate scannable barcodes.
- Can represent medication IDs or order codes.

---

Feel free to contribute or fork the project!
