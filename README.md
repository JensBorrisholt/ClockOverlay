# 🕒 ClockOverlay

ClockOverlay is a lightweight Windows utility that displays a **floating clock** in the upper-right corner of your screen.  
It shows both **digital and analog time**, including seconds, and can be quickly toggled using the system tray.

![ClockOverlay Preview](./ClockOverlay/Generated%20Themes/Light.png)

---

## ✨ Features

- **Toggle the clock instantly**  
  Click the ClockOverlay icon in the Windows system tray to show the clock.  
  Click anywhere on screen or press **Escape** to hide it again.

- **Digital + Analog clock**  
  Both styles are shown together in a clean overlay.

- **Startup integration**  
  - Launch with `/install` to register ClockOverlay for automatic startup  
  - Launch with `/uninstall` to remove it from automatic startup

- **Rich theme support**  
  Choose from a wide range of visual styles (see below).

- **Low-level system hooks**  
  The application uses a **LL Mouse Hook** and **LL Keyboard Hook** for fast toggle behavior with minimal overhead.

- **Built with C# and Windows Forms**  
  Simple, reliable, and optimized for Windows 10/11.

---

## 🎨 Available Themes
 
| Theme | Preview |
|-------|---------|
| **Accent** | ![](./ClockOverlay/Generated%20Themes/Accent.png) |
| **AeroBlue** | ![](./ClockOverlay/Generated%20Themes/AeroBlue.png) |
| **BrassAntique** | ![](./ClockOverlay/Generated%20Themes/BrassAntique.png) |
| **CarbonFiber** | ![](./ClockOverlay/Generated%20Themes/CarbonFiber.png) |
| **Classic95** | ![](./ClockOverlay/Generated%20Themes/Classic95.png) |
| **Dark** | ![](./ClockOverlay/Generated%20Themes/Dark.png) |
| **FireRed** | ![](./ClockOverlay/Generated%20Themes/FireRed.png) |
| **GlassDark** | ![](./ClockOverlay/Generated%20Themes/GlassDark.png) |
| **GlassLight** | ![](./ClockOverlay/Generated%20Themes/GlassLight.png) |
| **Light** | ![](./ClockOverlay/Generated%20Themes/Light.png) |
| **MinimalisticWhite** | ![](./ClockOverlay/Generated%20Themes/MinimalisticWhite.png) |
| **Neon** | ![](./ClockOverlay/Generated%20Themes/Neon.png) |
| **OceanBlue** | ![](./ClockOverlay/Generated%20Themes/OceanBlue.png) |
| **RadialMetal** | ![](./ClockOverlay/Generated%20Themes/RadialMetal.png) |
| **Retro** | ![](./ClockOverlay/Generated%20Themes/Retro.png) |
| **Sunburst** | ![](./ClockOverlay/Generated%20Themes/Sunburst.png) |
| **Win2000** | ![](./ClockOverlay/Generated%20Themes/Win2000.png) |
| **Win311** | ![](./ClockOverlay/Generated%20Themes/Win311.png) |
| **WinME** | ![](./ClockOverlay/Generated%20Themes/WinME.png) |
| **XpLunaBlue** | ![](./ClockOverlay/Generated%20Themes/XpLunaBlue.png) |
| **XpLunaOlive** | ![](./ClockOverlay/Generated%20Themes/XpLunaOlive.png) |

---

## 🚀 Usage

### Show the Clock
Simply click the ClockOverlay icon in the Windows system tray.

### Hide the Clock
- Click anywhere with the mouse  
- Or press **Escape**

### Install to Startup
```
ClockOverlay.exe /install
```

### Remove from Startup
```
ClockOverlay.exe /uninstall
```

---

## ⚙️ Configuration (appsettings.json)

ClockOverlay can be customized through an `appsettings.json` file placed next to the executable.  
Changes take effect **immediately** — no restart required.

### Available settings

- **Theme**  
  Select any of the built-in themes (see theme table above).  
  Example: `"Theme": "Neon"`

- **DigitalLabelHeight**  
  Controls the height of the digital clock label.  
  Example: `"DigitalLabelHeight": 60`

### Example `appsettings.json`

```json
{
  "Theme": "Neon",
  "DigitalLabelHeight": 60
}
```

ClockOverlay automatically reloads this file using `reloadOnChange`, so updates to the theme or digital label size are applied **live** while the application is running.

---

## 🏗️ Technical Overview

ClockOverlay is built with:

- **C# / .NET**
- **Windows Forms**
- **Low-Level Mouse Hook** (LLMHF)
- **Low-Level Keyboard Hook** (LLKHF)
- **High-performance theme rendering system**
- **Automatic theme preview generator**

The application is designed to use minimal CPU and memory, even when running continuously.

---

## 📂 Project Structure

```
ClockOverlay/
|-- Render/
|   |-- ClockFaceRendererBase.cs
|   |-- ThemeManager.cs
|   `-- Themes/
|       |-- AccentClockFaceRenderer.cs
|       |-- ...
|       `-- XpLunaOliveClockFaceRenderer.cs
|
|-- UI/
|   |-- ClockForm.cs
|   `-- TrayIconService.cs
|
|-- Generated Themes/
|   |-- Accent.png
|   |-- ...
|   `-- XpLunaOlive.png
|
`-- Program.cs
```

---

## 📜 License

```
                               Apache License
                           Version 2.0, January 2004
                        http://www.apache.org/licenses/
```

---

## 💡 Contributions

Pull requests, bug reports, and theme suggestions are welcome!
