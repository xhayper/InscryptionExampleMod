# InscryptionExampleMod

A BepInEx plugin example for a card game called "Inscryption"

# Getting Started

- Edit everything with the word `InscryptionExampleMod` to anything you want.
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
- A: By using [NStrip](https://github.com/BepInEx/NStrip) with the options `-p -n --keep-resources` in `<ROOT_GAME_DIRECTORY>/Inscryption_Data/Managed` with the file called `Assembly-CSharp.dll`