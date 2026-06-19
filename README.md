# TinySparkline-Vb.net

A lightweight, high-performance sparkline control for VB.NET WinForms applications. Perfect for displaying real-time data trends in a minimal footprint.

![Main Interface](DeviceMonitor.gif)

## 📊 Overview

**TinySparkline** is a custom Windows Forms control that displays mini line charts (sparklines) with:
- Real-time data visualization
- Auto-scaling Y-axis
- Fill area under the curve
- Directional color coding (green for up, red for down)
- Last point highlighting
- Full property grid support
- Zero external dependencies

## ✨ Features

### Core Features
- ✅ **Ultra-lightweight** - Minimal CPU and memory usage
- ✅ **Async/Await Updates** - No Timer controls, smooth performance
- ✅ **Auto-scaling** - Automatically adjusts to your data range
- ✅ **Directional Colors** - Green for upward trends, Red for downward
- ✅ **Fill Area** - Semi-transparent fill under the line
- ✅ **Last Point Indicator** - Highlights the most recent data point
- ✅ **Full Property Support** - All properties visible in designer PropertyGrid
- ✅ **Real-time Updates** - Simulated data with random changes
- ✅ **Pause/Resume** - Control the auto-update loop

### Controls
| Control | Description |
|---------|-------------|
| **Add** | Manually add one device |
| **Remove** | Manually remove one device |
| **Reset** | Reset to initial data |
| **Pause/Resume** | Pause or resume auto-updates |

## 🚀 Installation

### Method 1: Add to Existing Project
1. Copy `TinySparkline.vb` to your project
2. Build the project
3. The control will appear in the Toolbox under your project namespace
4. Drag and drop onto your form

### Method 2: Complete Project
Download the complete project files:
- `TinySparkline.vb` - The control
- `MainForm.Designer.vb` - Form designer code
- `MainForm.vb` - Form logic

## 💻 Usage Example

### Basic Usage

```vbnet
' Create and add sparkline
Dim sparkline As New TinySparkline()
sparkline.Size = New Size(100, 30)
sparkline.Location = New Point(10, 10)
Me.Controls.Add(sparkline)

' Add data
sparkline.AddValue(10)
sparkline.AddValue(12)
sparkline.AddValue(8)
sparkline.AddValue(15)
```

## 🎨 Customization Examples

### Change Colors

```vbnet
sparkline.LineColor = Color.Blue
sparkline.LineColorDown = Color.Orange
sparkline.FillColor = Color.FromArgb(50, 0, 0, 255)
```

## ⚡ Quick Start Code

```vbnet
' Create a sparkline with default settings
Dim spark As New TinySparkline()
spark.Size = New Size(120, 35)
spark.Location = New Point(10, 10)
Me.Controls.Add(spark)

' Add data
spark.AddRange(New Integer() {5, 7, 4, 8, 6, 9, 3, 10, 8, 12})

' Update with new value (auto-removes oldest)
spark.AddValue(11)

' Check trend
If spark.Change > 0 Then
    Console.WriteLine("Trending Up!")
End If
```
