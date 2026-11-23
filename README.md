<!-- markdownlint-disable MD033 -->
# SWalter.Core.Avalonia

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)](LICENSE)
[![Target: .NET 10.0](https://img.shields.io/badge/.NET-10.0-512bd4.svg?style=for-the-badge&logo=dotnet)](Directory.Build.props)

Avalonia UI extensions, controls, and headless testing utilities for .NET applications.

---

## 📈 Quality & Activity

| Branch                                                                                                                | Status & Activity                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| :-------------------------------------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| ![Main](https://img.shields.io/badge/branch-main-brightgreen?style=flat-square&logo=git&logoColor=white&color=c9ff00) | [![CodeFactor](https://www.codefactor.io/repository/github/swalterlabs/SWalter.Core.Avalonia/badge/main?style=flat-square)](https://www.codefactor.io/repository/github/swalterlabs/SWalter.Core.Avalonia/overview/main) ![Commit Activity Main](https://img.shields.io/github/commit-activity/m/swalterlabs/SWalter.Core.Avalonia/main?style=flat-square) ![Last Commit Main](https://img.shields.io/github/last-commit/swalterlabs/SWalter.Core.Avalonia/main?style=flat-square)                   |
| ![Develop](https://img.shields.io/badge/branch-develop-blue?style=flat-square&logo=git&logoColor=white&color=0080ff)  | [![CodeFactor](https://www.codefactor.io/repository/github/swalterlabs/SWalter.Core.Avalonia/badge/develop?style=flat-square)](https://www.codefactor.io/repository/github/swalterlabs/SWalter.Core.Avalonia/overview/develop) ![Commit Activity Develop](https://img.shields.io/github/commit-activity/m/swalterlabs/SWalter.Core.Avalonia/develop?style=flat-square) ![Last Commit Develop](https://img.shields.io/github/last-commit/swalterlabs/SWalter.Core.Avalonia/develop?style=flat-square) |

---

## 📦 Packages in this Repository

| Package                                                    | Description                                                                    | Package Link                                                                                                                                                |
| :--------------------------------------------------------- | :----------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [`SWalter.Core.Avalonia`](src/SWalter.Core.Avalonia)       | Avalonia UI extensions, FluentAvalonia themes, behaviors, and control helpers. | [![MyGet](https://img.shields.io/badge/MyGet-gray?style=flat-square&logo=myget)](https://myget.org/feed/swalterlabs/package/nuget/SWalter.Core.Avalonia)    |
| [`SWalter.Testing.Avalonia`](src/SWalter.Testing.Avalonia) | Headless testing utilities and helpers for Avalonia UI controls.               | [![MyGet](https://img.shields.io/badge/MyGet-gray?style=flat-square&logo=myget)](https://myget.org/feed/swalterlabs/package/nuget/SWalter.Testing.Avalonia) |

---

## 🚀 Package Feeds

All packages (Release and Preview builds) are published to **MyGet**.

| Registry  | Feed URL                                                |
| :-------- | :------------------------------------------------------ |
| **MyGet** | `https://www.myget.org/F/swalterlabs/api/v3/index.json` |

### Add Feed via .NET CLI

```bash
dotnet nuget add source https://www.myget.org/F/swalterlabs/api/v3/index.json -n "SWalter Labs"
```

<details>
<summary><b>Sample <code>NuGet.Config</code> with Package Source Mapping</b></summary>

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
    <!-- Choose one of the following feeds: -->
    <add key="SWalter Labs" value="https://www.myget.org/F/swalterlabs/api/v3/index.json" />
  </packageSources>

  <packageSourceMapping>
    <packageSource key="nuget.org">
      <package pattern="*" />
    </packageSource>
    <packageSource key="SWalter Labs">
      <package pattern="SWalter.*" />
    </packageSource>
  </packageSourceMapping>
</configuration>
```

</details>

---

## 📥 Installation

Install any package via `dotnet add package`:

### Standard Release

```bash
dotnet add package SWalter.Core.Avalonia
dotnet add package SWalter.Testing.Avalonia
```

### Preview Builds

```bash
dotnet add package SWalter.Core.Avalonia --prerelease
dotnet add package SWalter.Testing.Avalonia --prerelease
```
