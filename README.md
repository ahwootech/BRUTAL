<p align="center">
  <img src="https://ahwoo.com/brutal-branding/LOGO_BRUTAL_WHT.png" alt="BRUTAL" width="360">
</p>

<h3 align="center">Built for games that are hard to make.</h3>

<p align="center">
  <a href="https://ahwoo.com/brutal">Website</a> ·
  <a href="https://www.nuget.org/profiles/Ahwoo">NuGet</a> ·
  <a href="https://forums.ahwoo.dev/forums/brutal/">Forums</a> ·
  <a href="https://discord.gg/MEuNTYbAh8">Discord</a> ·
  <a href="LICENSE">BRUTAL License</a>
</p>

---

**BRUTAL** is a C# game development framework from Ahwoo and RocketWerkz. It gives modern .NET direct, low-overhead access to native APIs and high-performance C and C++ libraries, including Vulkan.

BRUTAL is **a framework, not a game engine**. You can make a game directly with it, as we did with [Kitten Space Agency](https://ahwoo.com/app/100000/kitten-space-agency/), or use it as the foundation for your own engine, as Ludeon did with Waylith for [RimWorld](https://ludeon.com/blog/2026/10/announcing-the-waylith-engine-and-update-1-7/).

It's free to use, including for commercial games, with no royalties. It does have an [attribution requirement](#licence).

## Why BRUTAL

General-purpose engines are built around assumptions that suit most games. If your game sits far from that average, you spend much of your time working around the engine rather than on your game.

BRUTAL takes the other approach. It does a small number of low-level things extremely well and leaves the architecture to you:

- **A custom interop layer** that gives C# direct access to native APIs and libraries
- **Unmanaged memory and unsafe code where it matters**, with an obsessive focus on avoiding allocations and overhead
- **Bindings that follow each API as designed**, so existing Vulkan (or GLFW, Jolt, FMOD…) knowledge transfers unchanged
- **Supporting libraries** for maths, numerics, memory, collections, strings, job scheduling, logging and localisation
- **Your own stack.** Use any NuGet packages you like. There's no engine loop to hook into, because your game owns its frame.

> **It's called BRUTAL for a reason.** There are no guardrails, no editor and no ready-made renderer. You're responsible for the systems you build. In exchange, you can see and change everything, all the way down. If you want an engine that makes the decisions for you, Unity, Unreal or Godot will serve you better.

## Built with BRUTAL

| | |
|---|---|
| **[Kitten Space Agency](https://ahwoo.com/app/100000/kitten-space-agency/)** · RocketWerkz | The first game built from scratch on BRUTAL. It simulates a real solar system at real scale. Winner of Most Innovative Hi-Tech Creative Technology Solution at the 2026 NZ Hi-Tech Awards. |
| **[RimWorld 1.7](https://ludeon.com/blog/2026/10/announcing-the-waylith-engine-and-update-1-7/)** · Ludeon Studios | Ludeon built Waylith, RimWorld's new engine, on BRUTAL. They report 2–4× faster performance in their tests. |

## Getting started

> ⚠️ **TODO before launch:** confirm the published package IDs and add a minimal example. Fill this section in from the same instructions as the "How to get started" section of Dean's announcement post.

**Requirements:** [.NET 10](https://dotnet.microsoft.com/download) · Windows, Linux or macOS · a Vulkan-capable GPU for graphics

BRUTAL ships as NuGet packages under the [Ahwoo profile](https://www.nuget.org/profiles/Ahwoo). Add only the modules you need:

```sh
dotnet add package Ahwoo.BRUTAL.Core
dotnet add package Ahwoo.BRUTAL.Vulkan
dotnet add package Ahwoo.BRUTAL.Glfw
```

<!-- TODO: link a minimal "window + clear screen" sample once one is published -->

## What's in the box

Every package targets Windows, Linux and macOS.

**Foundations**

| Module | What it does |
|---|---|
| `Brutal.Core` | Core types, pointers and platform helpers that everything else builds on |
| `Brutal.Interop` | The interop layer between C# and native libraries |
| `Brutal.Memory` | Direct unmanaged memory allocation |
| `Brutal.Collections` | Allocation-free collections and pools |
| `Brutal.Concurrency` | Job scheduling and threading primitives |
| `Brutal.Numerics` · `Brutal.Maths` | Vector, matrix and quaternion types (including double precision) with SIMD support |
| `Brutal.Strings` · `Brutal.Logging` · `Brutal.Localization` | Strings, logging and localisation |
| `Brutal.Monitor` | Process monitoring and crash capture |

**Graphics**

| Module | Binds |
|---|---|
| `Brutal.Vulkan` | Vulkan, plus the Vulkan Memory Allocator |
| `Brutal.OpenGL` | OpenGL |
| `Brutal.Render` | Mesh-building helpers |
| `Brutal.Texture` · `Brutal.Gli` · `Brutal.Ktx` · `Brutal.Stb` | Texture loading and formats |
| `Brutal.Gltf` · `Brutal.MeshOptimizer` | glTF loading and mesh optimisation |
| `Brutal.ImGui` | Dear ImGui |
| `Brutal.FreeType` | Font rasterisation |
| `Brutal.RenderDoc` | RenderDoc capture integration |

**Platform, input and audio**

| Module | Binds |
|---|---|
| `Brutal.Glfw` · `Brutal.Sdl` | Windowing and input |
| `Brutal.NativeFileDialog` | Native file dialogs |
| `Brutal.Notcurses` | Terminal UI |
| `Brutal.FMOD` · `Brutal.OpenAL` | Audio |

**Physics, networking and data**

| Module | Binds |
|---|---|
| `Brutal.Jolt` | Jolt Physics (3D) |
| `Brutal.Box2D` | Box2D (2D physics) |
| `Brutal.RakNet` | RakNet networking |
| `Brutal.Zlib` | Compression |

<!-- TODO: check the one-line module descriptions with the enterprise team before launch -->

Third-party libraries keep their own licences, which are listed in each package's `LICENSES/` directory. Some, such as FMOD, have their own licence terms that you must meet separately.

## Licence

BRUTAL is released under the **[BRUTAL License v1.0](LICENSE)**, which is based on MIT with extra attribution requirements. You can use, modify and distribute BRUTAL for free, including in commercial games, with no royalties.

Any game or product built with BRUTAL must:

1. **Credit:** include the BRUTAL copyright notice in its credits screen, or equivalent (§2.1)
2. **Logo:** show the BRUTAL logo from [ahwoo.com/brutal-branding](https://ahwoo.com/brutal-branding) before gameplay begins (§2.2)
3. **Notice:** ship `NOTICE.txt` alongside the product (§2.3)

To ask about waiving the logo requirement (for example for non-profit projects) or about a separate commercial licence, contact Ahwoo at **[CONTACT ADDRESS]**.

We describe BRUTAL as open source. Our custom licence hasn't been reviewed by the Open Source Initiative, and we welcome discussion about that and plan to develop the licence with community feedback.

## Contributing

Issues and pull requests are welcome. We're a small team, so please be patient with us. BRUTAL's scope is kept deliberately tight, and pull requests that drift away from that purpose will be declined. Read **[CONTRIBUTING.md](CONTRIBUTING.md)** before opening one. It covers scope, AI-assisted contributions and the Contribution Grant (§5.0).

- Questions and help: [BRUTAL forums](https://forums.ahwoo.dev/forums/brutal/guides-and-help/)
- Security issues: see [SECURITY.md](SECURITY.md). Please don't open a public issue.
- Code of Conduct: [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md)

## Credits

BRUTAL is developed by the Enterprise team at RocketWerkz, in collaboration with Ahwoo. See [CONTRIBUTORS.md](CONTRIBUTORS.md) for the people who built it.

---

<sub>BRUTAL is Copyright © 2024 Ahwoo Limited. Kitten Space Agency is a trademark of RocketWerkz. RimWorld is a trademark of Ludeon Studios.</sub>
