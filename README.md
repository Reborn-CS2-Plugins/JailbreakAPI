# JailbreakAPI

A CounterStrikeSharp API contract library for CS2 jailbreak plugins. This is **not a plugin** — it is a shared library that defines interfaces, classes, and types used by other jailbreak plugins to interact with the jailbreak system.

## Installation

1. Download the latest release from the [Releases](https://github.com/Reborn-CS2-Plugins/JailbreakAPI/releases) page
2. Extract and place the compiled DLL into `addons/counterstrikesharp/shared/`
3. Other jailbreak plugins can now reference this library in their projects
4. Restart your CS2 server once all plugins using the API are installed

> **Important:** This library goes in the `/shared` folder, **NOT** in `/plugins/`

## Purpose

- **API contract** — defines interfaces and classes that other plugins implement or depend on
- **Type definitions** — provides common types, enums, and data structures for jailbreak plugins
- **Plugin interoperability** — allows multiple jailbreak plugins to communicate and share data through a common interface
- **Development reference** — plugin developers can reference this library when building jailbreak-related features

## For Plugin Developers

When developing jailbreak plugins for this interface, add a reference to `JailbreakAPI.dll` in your `.csproj`:

```xml
<Reference Include="JailbreakAPI">
    <HintPath>JailbreakAPI.dll</HintPath>
</Reference>
```

Then use types and interfaces from the `JailbreakAPI` namespace to integrate with the jailbreak system.

## License

This project is licensed under the **Creative Commons Attribution-NonCommercial 4.0 International License (CC BY-NC 4.0)**.

You are free to:
- Share, copy and redistribute the material in any medium or format for **non-commercial purposes**.

Under the following terms:
- **Attribution**: You must give appropriate credit, provide a link to the license, and indicate if changes were made. You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.
- **NonCommercial**: You may not use the material for commercial purposes (e.g., selling or monetizing the software).

For full details, please see the [CC BY-NC 4.0 License](https://creativecommons.org/licenses/by-nc/4.0/legalcode).
