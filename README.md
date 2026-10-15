<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="docs/branding/LOGO_BRUTAL_WHT.png">
    <img src="docs/branding/LOGO_BRUTAL_BLK.png" alt="BRUTAL" width="360">
  </picture>
</p>

# BRUTAL Framework

**A free, open source C# framework for making games, or your own game engine.**

BRUTAL is a framework. You can make a game directly with it, or use it as the foundation for a separate engine. We made Kitten Space Agency directly on BRUTAL. Ludeon built their Waylith engine on it to move RimWorld off Unity.

At its core is a custom interop layer giving C# direct access to native APIs and libraries. Around that we've built mathematics, memory management, strings, collections, job scheduling, logging, localization, and bindings for Vulkan, GLFW, Dear ImGui, FMOD, RakNet, Jolt and Box2D. BRUTAL doesn't make the architectural decisions for you. You write your own stack. You can use whatever NuGet packages you want, including third-party ones.

It's called BRUTAL for a reason. In some ways it's much harder to use than Unity, Unreal or Godot. In other ways, particularly if you're doing something unusual, it's considerably easier. You actually have to know what you want to do first.

## Why

You are only as independent as your tools are.

Developers have surrendered an extraordinary amount of control over their work to companies whose interests are not necessarily aligned with their own. We're not suggesting everyone should make their own game engine. We're suggesting every developer should have the option to, without having to spend four years building the foundations first.

What that means in practice:

- **Free, including for commercial games.** No royalties. We don't want a percentage of your game's revenue. We ask for credit.
- **Open source.** The source is here under an MIT-based licence. If one day we stop being accountable to developers, you can fork it and go your own way.
- **Deliberately small.** We do a few low-level things well: interop, memory, concurrency, maths, strings, and bindings to native libraries, on the latest C# and Vulkan. We avoid allocations and unnecessary overhead and use unmanaged memory and unsafe code where it makes sense.
- **A foundation, like a kernel.** Think of the Linux kernel and something like Ubuntu. It's not an exact comparison, but it gets the idea across. We provide the foundation and you build your own systems on top.

### What BRUTAL is not

BRUTAL is not trying to be a general-purpose engine. There is no editor, no scene graph and no renderer, and we're not adding them. We push back on efforts to add more, because adding everything is how the industry ended up with the kind of engines we don't want to use. Pull requests that drift away from a clear purpose will be rejected.

## Projects using BRUTAL

| Product | Studio | Engine (if any) |
| --- | --- | --- |
| [RimWorld](https://store.steampowered.com/app/294100/RimWorld/) | Ludeon Studios | Waylith |
| [Kitten Space Agency](https://ahwoo.com/app/100000/kitten-space-agency/) | RocketWerkz | Direct on BRUTAL |
| Torpedia | RocketWerkz | Direct on BRUTAL |
| Art of the Rail | RocketWerkz | Direct on BRUTAL |
| [Gruntz](https://www.youtube.com/watch?v=ROB5IilenZE) | RocketWerkz | Direct on BRUTAL |
| Afterskies | Floating Origin Interactive | Direct on BRUTAL |

Ludeon report 2 to 4 times the performance of the Unity build in their own tests, with the vast majority of existing mods still compatible. See their [Steam announcement](https://steamcommunity.com/games/294100/announcements/detail/672882362547178634).

Kitten Space Agency is a free pre-alpha spaceflight simulation. It runs a solar system at real scale, and is the first major project built directly on BRUTAL. [Download it on Ahwoo](https://ahwoo.com/app/100000/kitten-space-agency/) and see the technology yourself.

## What is in the box

Each top-level folder in this repository is one library, published as a NuGet package. Reference only the ones you need.

| Library | What it is |
| --- | --- |
| `Brutal.Core` | Base types, attributes, platform detection, pointer helpers, Roslyn analyzers |
| `Brutal.Interop` | The custom interop layer that gives C# direct access to native APIs |
| `Brutal.Memory` | Unmanaged memory management and allocators |
| `Brutal.Collections` | Collections that don't allocate |
| `Brutal.Strings` | String building and handling without allocation |
| `Brutal.Maths`, `Brutal.Numerics` | Vector, matrix and numeric types |
| `Brutal.Concurrency` | Job system and threading |
| `Brutal.Logging` | Logging |
| `Brutal.Localization` | Localization |
| `Brutal.Vulkan`, `Brutal.Vulkan.Abstractions`, `Brutal.Vulkan.Vma` | Vulkan bindings, abstractions and the Vulkan Memory Allocator |
| `Brutal.OpenGl` | OpenGL bindings |
| `Brutal.ShaderC`, `Brutal.Slang` | Shader compilation |
| `Brutal.Glfw`, `Brutal.Sdl`, `Brutal.Sdl.Image`, `Brutal.Sdl.Mixer`, `Brutal.Sdl.Ttf` | Windowing and input, with SDL's image, audio mixing and font add-ons |
| `Brutal.ImGui`, `Brutal.ImGui.*`, `Brutal.ImPlot` | Dear ImGui and ImPlot bindings, docking branch |
| `Brutal.Render.Mesh` | Mesh utilities |
| `Brutal.Texture`, `Brutal.Texture.Abstractions`, `Brutal.Ktx`, `Brutal.Gli`, `Brutal.Stb` | Texture loading, KTX and compressed formats, image decoding |
| `Brutal.Gltf`, `Brutal.MeshOptimizer` | glTF loading and mesh optimisation |
| `Brutal.FreeType` | Font rasterisation |
| `Brutal.Fmod`, `Brutal.OpenAl` | Audio |
| `Brutal.RakNet` | Networking |
| `Brutal.Jolt`, `Brutal.Box2D` | 3D and 2D physics |
| `Brutal.Monitor.Common`, `Brutal.Monitor.Host`, `Brutal.RenderDoc`, `Brutal.RenderDoc.ImGui` | Runtime monitoring and RenderDoc capture integration |
| `Brutal.NativeFileDialog`, `Brutal.NotCurses`, `Brutal.ZLib` | Native file dialogs, terminal UI, compression |

Third-party notices for each library live in its `LICENSES` folder, `Brutal.ImGui/LICENSES` say.

## Getting started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- A Vulkan 1.3 capable GPU with current drivers (if you render)
- The [Vulkan SDK](https://vulkan.lunarg.com/) if you want validation layers while developing
- Windows or Linux

### Your first window

Create a project and add Core and Glfw:

```sh
dotnet new console -n HelloBrutal
cd HelloBrutal
dotnet add package Ahwoo.Brutal.Core
dotnet add package Ahwoo.Brutal.Glfw
```

Replace `Program.cs`:

```csharp
using Brutal.GlfwApi;
using Brutal.Numerics;

if (!Glfw.Init())
    throw new Exception("Failed to initialize GLFW");

Glfw.WindowHint(GlfwWindowHint.ClientApi, 0);
var window = Glfw.CreateWindow(new GlfwWindow.CreateInfo
{
    Title = "Hello BRUTAL",
    Size = new int2(1280, 720),
});

while (!window.ShouldClose)
    Glfw.PollEvents();

Glfw.Terminate();
```

```sh
dotnet run
```

That opens a window with no graphics API. What you add next is up to you:

- **Rendering:** `Ahwoo.Brutal.Vulkan.Abstractions` and `Ahwoo.Brutal.Vulkan.Vma` for a Vulkan renderer, `Ahwoo.Brutal.ShaderC` to compile shaders at runtime.
- **Debug UI:** `Ahwoo.Brutal.ImGui` and `Ahwoo.Brutal.ImPlot`.
- **Parallelism:** `Ahwoo.Brutal.Concurrency` for the job system.
- **Audio and networking:** `Ahwoo.Brutal.Fmod`, `Ahwoo.Brutal.RakNet`.

Questions and "how do I" threads go on the [Guides and Help forum](https://forums.ahwoo.com/forums/brutal/guides-and-help/).

### Building from source

This is the source for every published package. Project files, a solution and build scripts are coming. Until then use the NuGet packages, and use this repository to read and fork the code.

```sh
git clone https://github.com/ahwootech/BRUTAL.git
```

## Licence

BRUTAL is free to use, modify and distribute, including in commercial games. There are no royalties and we don't want a percentage of your game's revenue.

The licence is based on MIT with an added attribution requirement. A game or product built with BRUTAL:

1. includes the BRUTAL copyright notice in its credits screen, or equivalent (section 2.1)
2. shows the BRUTAL logo before gameplay starts (section 2.2)
3. ships `NOTICE.txt` alongside the product (section 2.3)

If you don't want to do that, we can arrange a separate commercial licence. We also waive the logo requirement for non-profit projects and where displaying it would be detrimental to the application's purpose.

BRUTAL is open source. There are already OSI-approved licences that allow graphical attribution. Ours is not yet OSI approved because we have not submitted it yet. We intend to, and to develop the licence with community feedback. See [LICENSE.txt](LICENSE.txt) for the full text.

Third-party components keep their own licences. Section 4.0 points at the `LICENSES` folder at the root of each NuGet package; in this repository, those notices are in the `LICENSES` folder of each library that redistributes them.

## Contributing

You can submit PRs and issues. We are a small team and maintaining a public framework is going to be a lot of work, so please be patient with us. We'll see what happens, assess the problems, and change our workflows as necessary. What won't change is BRUTAL's scope.

Before opening a PR, read [CONTRIBUTING.md](CONTRIBUTING.md). It covers scope, what we expect from AI-assisted contributions, the contribution grant in section 5.0 of the licence, and the sign-off every commit needs. Small changes you understand and have tested, with a clear purpose, are the ones that will get merged.

- Security issues: report them privately, see [SECURITY.md](SECURITY.md). Don't open a public issue.
- Conduct: [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md).

## Community

- Source: https://github.com/ahwootech/BRUTAL
- NuGet packages: https://www.nuget.org/profiles/Ahwoo
- Forums: https://forums.ahwoo.com/forums/brutal/
- Discord: https://discord.gg/MEuNTYbAh8

## Credits

BRUTAL was made by the RocketWerkz Enterprise team and others, named in [CONTRIBUTORS.md](CONTRIBUTORS.md). When we talk about wanting credit for BRUTAL, these are the people we are talking about.

BRUTAL is Copyright (c) 2024 Ahwoo Limited.
