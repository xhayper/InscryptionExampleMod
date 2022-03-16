# InscryptionExampleMod

A BepInEx plugin template for a card game called "Inscryption"

# Getting Started

- Edit `InscryptionExampleMod.csproj` and rename the file to anything you want (Keep the `csproj` extenstion)
- Run `dotnet restore`
- Start making your mod! 

# Building

To build the plugin, You have to run

```sh
> dotnet build
```

Then the plugin DLL file will appear in `bin/Debug/netstandard2.1/`

# Questions

- Q: How do you get `lib/Assembly-CSharp.dll`?
- A: By using [NStrip](https://github.com/BepInEx/NStrip) with the options `--keep-resources -p -n` in `<ROOT_GAME_DIRECTORY>/Inscryption_Data/Managed` with the file called `Assembly-CSharp.dll`