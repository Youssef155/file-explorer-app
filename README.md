# FileExplorerApp

FileExplorerApp is a simple and intuitive file management application designed to help users browse, organize, and manage files and directories on their device. It provides a dual-pane interface for easy file navigation and operations such as copying, moving, deleting, and renaming files and folders.

---

## Features

- **Drive Navigation**: Automatically detects and lists all drives on your system for quick access.
- **Folder and File Browsing**: Browse through directories and view their contents, including files and subdirectories.
- **File and Folder Operations**:
  - **Open Files**: Open any file directly with its associated program.
  - **Copy**: Copy files or folders to a different location.
  - **Move**: Move files or folders between locations using arrow buttons.
  - **Delete**: Delete files or folders with confirmation prompts to prevent accidental deletion.
- **Navigation Shortcuts**:
  - Navigate to parent directories using `..`.
  - Reload drives using `.`.
- **Detailed View**:
  - Displays file and folder attributes such as name, type (file or folder), and size.
- **Open Files**: Open files directly from the app using the default system application.
- **Dual-Pane Interface**: Manage files and folders efficiently with left and right panes.
- **Error Handling**: Gracefully handles errors like unauthorized access, invalid selections, or unexpected failures.

---

## Tech Stack

The FileExplorerApp is built using the following technologies:

- **Programming Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **IDE**: Visual Studio
- **Version Control**: Git
- **Operating System**: Windows

---

## Installation

To install and run the FileExplorerApp, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/Youssef155/FileExplorerApp.git

2. Open the Solution:
   - Navigate to the cloned directory.
   - Open `FileExplorerApp.sln` with Visual Studio.

3. Build the Solution:
   - Restore NuGet packages if prompted.
   - Build the solution using `Ctrl+Shift+B`.

4. Run the Application:
   - Press `F5` or click on the "Start" button in Visual Studio.

---

## Usage

1. **Launch the App**: Open the application after building it.

2. **Navigate Files**:
   - Use the left and right panes to browse files and folders.
   - Click on a folder to navigate into it.
   - Use `.` to return to the root drives and `..` to go up one directory level.

3. **Perform File Operations**:
   - **Copy**: Select a file or folder in one pane and click the **Copy** button to copy it to the other pane.
   - **Move**: Use the arrow buttons (`←` or `→`) to move files or folders between panes.
   - **Delete**: Select a file or folder and click the **Delete** button to remove it (with confirmation).

4. **Open Files**: Double-click on a file to open it with the default system application.
