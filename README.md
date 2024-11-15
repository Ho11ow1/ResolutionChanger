# ResolutionChanger

A simple automatic **ResolutionChanger** application built in C# that detects a specified process and changes the screen resolution accordingly.

## Features

- Automatically switches screen resolution when a specified process (e.g... Notepad) is detected.
- Easy to use and lightweight.
- Supports customizable resolutions and processes in the future.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0 or higher)
- [Visual Studio](https://visualstudio.microsoft.com/) / [Visual Studio Code](https://code.visualstudio.com/)

### Installation

### 1. Clone the repository:
```bash
git clone https://github.com/Ho11ow1/ResolutionChanger
```

### 2. Open the project in your preferred IDE.
```bash
# Alternatively change directory
cd ResolutionChanger/ResolutionChanger
```

### 3. Restore the project dependencies:
```bash
dotnet restore
```

### Usage

- The application runs continuously checking for the specified process (e.g... Notepad).
- When the process is detected, it changes the screen resolution to the defined dimensions (1280x720).
- If the process is not running, it reverts the resolution to the maximum supported (1920x1080).

## Future Development

- Allow users to define multiple processes and resolutions in a configuration file.
