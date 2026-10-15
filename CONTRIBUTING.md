# Contributing to BRUTAL

Thanks for your interest in BRUTAL. You can submit issues and pull requests. We're a small team, and maintaining a public framework is a lot of work, so please be patient with us. We'll see how things go at first and adjust our process as we learn. Feedback on that process is welcome on the [forums](https://forums.ahwoo.com/forums/brutal/general/).

## The short version

- **Questions and "how do I…?"** go to the [BRUTAL forums](https://forums.ahwoo.com/forums/brutal/guides-and-help/), not GitHub issues.
- **Bugs:** open an issue using the bug template, with a minimal repro.
- **Anything bigger than a small fix:** open an issue first and wait for a maintainer to agree the approach before you write the code.
- **Security problems:** report them privately. See [SECURITY.md](SECURITY.md).

## BRUTAL's scope

BRUTAL is a framework, not a game engine. At its core is an interop layer that gives C# access to native APIs and libraries, with supporting libraries for maths, memory, strings, job scheduling, logging, localisation and Vulkan bindings. It is built for "hard to make games", and its job is to do a few low-level things extremely well.

Think of the relationship between the Linux kernel and a distribution like Ubuntu. BRUTAL is the foundation, and developers build their own systems on top of it. **We're aggressive about keeping that scope.** Pull requests that drift away from that purpose will be declined, for example ones that:

- add engine-style features (scene graphs, editors, high-level renderers, gameplay systems)
- add abstractions over APIs that BRUTAL deliberately exposes directly
- add dependencies without prior discussion
- change public APIs without an agreed issue

That isn't because we don't appreciate contributions. Adding everything is how the industry ended up with the kinds of engines BRUTAL exists to avoid. If you build something on top of BRUTAL, please share it in the [Tools and Libraries](https://forums.ahwoo.com/forums/brutal/tools-and-libraries/) forum.

## Reporting bugs

Please include:

- BRUTAL package names and versions
- .NET version, OS and GPU/driver (for graphics issues)
- the smallest code sample that reproduces the problem
- what you expected and what happened instead (full exception and stack trace)

## Pull requests

1. Make sure an issue exists and a maintainer has agreed the approach (typo and tiny doc fixes excepted).
2. Keep the PR focused on one change.
3. Follow the existing code style. Avoid allocations in hot paths, and don't add abstraction for its own sake.
4. Build and test on at least one target (Windows, Linux or macOS), and say which.
5. Sign off every commit (see below).

### Agentic and AI-assisted contributions

Agentic tools can make you very productive. They also make it easy to submit large amounts of code without understanding it, testing it, or considering how it fits into the project. You may use them, but you are responsible for every line you submit: you must understand it, have tested it, and be able to explain it in review. Say in the PR description if a substantial part was AI-generated. Large, untested or unexplained AI-generated PRs will be closed without review.

## Licensing of contributions

BRUTAL is distributed under the [BRUTAL License](LICENSE.txt). **Section 5.0 of the licence covers contributions.** By submitting a contribution you grant Ahwoo Limited and all recipients of BRUTAL a perpetual, worldwide, non-exclusive, royalty-free, irrevocable licence to include it in BRUTAL and use it under the licence's terms. You also confirm that you're legally entitled to grant that licence and that your contribution doesn't infringe anyone else's rights. Please read section 5.0 before opening a PR.

Third-party components that BRUTAL redistributes keep their own licences, listed in the `LICENSES/` directory (section 4.0). Don't add third-party code without discussing it in an issue first.

### Sign-off (Developer Certificate of Origin)

Each commit must be signed off to confirm you agree to the [Developer Certificate of Origin](https://developercertificate.org/). Use `git commit -s`, which adds:

```
Signed-off-by: Your Name <you@example.com>
```

## Using BRUTAL in your own game

You don't need to contribute to use BRUTAL. It's free, including for commercial games, with no royalties. The licence asks three things of any game or product built with it:

- **2.1:** the copyright notice in your Credits screen (or equivalent)
- **2.2:** the BRUTAL logo from [ahwoo.com/brutal-branding](https://ahwoo.com/brutal-branding) shown before gameplay starts
- **2.3:** `NOTICE.txt` shipped alongside your game

For a logo waiver (for example non-profit projects, or where the logo would get in the way of the product's purpose) or a separate commercial licence, contact Ahwoo at **brutal@ahwoo.com**.

## Code of Conduct

Everyone taking part in BRUTAL spaces is expected to follow our [Code of Conduct](CODE_OF_CONDUCT.md).
