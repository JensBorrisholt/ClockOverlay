# 🕒 ClockOverlay

ClockOverlay is a lightweight Windows utility that displays a **floating clock** in the upper-right corner of your screen.  
It shows both **digital and analog time**, including seconds, and can be quickly toggled using the system tray.

![ClockOverlay Preview](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Light.png)

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
| **Accent** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Accent.png) |
| **AeroBlue** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/AeroBlue.png) |
| **BrassAntique** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/BrassAntique.png) |
| **CarbonFiber** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/CarbonFiber.png) |
| **Classic95** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Classic95.png) |
| **Dark** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Dark.png) |
| **FireRed** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/FireRed.png) |
| **GlassDark** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/GlassDark.png) |
| **GlassLight** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/GlassLight.png) |
| **Light** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Light.png) |
| **MinimalisticWhite** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/MinimalisticWhite.png) |
| **Neon** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Neon.png) |
| **OceanBlue** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/OceanBlue.png) |
| **RadialMetal** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/RadialMetal.png) |
| **Retro** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Retro.png) |
| **Sunburst** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Sunburst.png) |
| **Win2000** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Win2000.png) |
| **Win311** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/Win311.png) |
| **WinME** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/WinME.png) |
| **XpLunaBlue** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/XpLunaBlue.png) |
| **XpLunaOlive** | ![](https://github.com/JensBorrisholt/ClockOverlay/tree/main/Generated%20Themes/Generated%20Themes/XpLunaOlive.png) |

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

                               Apache License
                           Version 2.0, January 2004
                        http://www.apache.org/licenses/
---

## 💡 Contributions

Pull requests, bug reports, and theme suggestions are welcome!
