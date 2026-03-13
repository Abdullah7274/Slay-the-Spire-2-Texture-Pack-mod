# Texture Replacer Mod

Texture Replacer mod for Slay the Spire 2

---

## Prerequisites

Before you begin, ensure you have:

- Slay the Spire 2 installed via Steam
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Godot 4.5.1](https://godotengine.org/download/archive/4.5.1-stable/) - **Download the "Windows 64-bit, .NET" version**

---

## Setup

### 1. Configure Your Paths

Open `local.props` in any text editor and update with **your** paths:
```xml
<Project>
  <PropertyGroup>
    <!-- The example mod says to use the steam path directly, but I kept 
	     getting errors so I used my own folder and copied it manually
		 
		 original path:
         C:\Program Files (x86)\Steam\steamapps\common\Slay the Spire 2
    -->
    <!-- Path to your Slay the Spire 2 installation -->
    <STS2GamePath>C:\Users\[USER]\Desktop\Modding\Slay the spire 2</STS2GamePath>
    
    <!-- Path to Godot 4.5.1 Mono executable -->
    <!-- Download from: https://godotengine.org/download/archive/4.5.1-stable/ -->
    <GodotExePath>C:\Users\[USER]\Desktop\Modding\Godot\Godot_v4.5.1-stable_win64.exe</GodotExePath>
  </PropertyGroup>
</Project>
```

---

### 2. Edit the textures

- Edit the .psd files with your own custom art. You can also edit the existing .png files if you prefer.
- Export it as a png to `pack/images/atlases`.
- **Don't change the size or file name of the images**, just replace the existing ones.

---

### 3. Building the Mod

- Open TextureReplacerMod.csproj as Visual Studio Project

- Press **Ctrl+Shift+B** or click **Build → Build Solution**


- The mod will **automatically** install to the chosen directory.

- Copy both `TextureReplacerMod.dll` and `TextureReplacerMod.pck` to your mods folder:

Slay the Spire 2/mods/TextureReplacerMod/  
├── TextureReplacerMod.dll  
└── TextureReplacerMod.pck  

- You can also try using the steam path directly

---

## Troubleshooting

### "Cannot find Godot executable"
- Make sure `GodotExePath` in `local.props` points to the `.exe` file
- Example mod said to use the mono version, but I used the regular version and it worked fine.
- Just make sure the path is correct and points to the executable.

### "Cannot find Slay the Spire 2"
- Right-click STS2 in Steam → Manage → Browse local files
- Copy the full path and paste into `STS2GamePath`

### Build succeeds but mod doesn't load
- Check that both `TextureReplacerMod.dll` **AND** `TextureReplacerMod.pck` exist in `mods/TextureReplacerMod/`
- Check the game's log file for errors: `%AppData%\Roaming\SlayTheSpire2\logs\godot.log`

### Changes don't appear in game
- Rebuild the mod (**Ctrl+Shift+B**) or with Rebuild Solution
- Restart Slay the Spire 2

### "Don't have permission to access the game directory"
- Run visual studio as administrator

---

## Credits

Built using [sts2_example_mod](https://github.com/lamali292/sts2_example_mod.git) by lamali292

---