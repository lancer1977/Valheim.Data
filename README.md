# Valheim.Data

**Valheim.Data** is a C# library and tooling repository designed to support working with **Valheim game data**.  
It provides strongly-typed models, documentation tooling, and tests to help modders, tooling developers, and server integrations consume Valheim data in a reliable and maintainable way.

---

## 🚀 Project Overview

Valheim.Data exists to make **Valheim game data accessible and consumable** for external tools and services.

Key goals of this repository:

- 📦 Strongly-typed C# models for Valheim game data
- 📚 Auto-generated documentation using DocFX
- 🧪 Tests to validate data consistency
- 🧰 A foundation for modding tools, APIs, and automation

This project is ideal for developers building:
- Valheim mods or helpers
- REST APIs or backend services
- Server management or automation tools
- Dashboards or data visualizations

---

## 📁 Repository Structure

```
/
├── src/                # Core C# library source
├── test/               # Unit tests
├── docs/               # DocFX documentation source
├── images/             # Images used by documentation
├── Valheim.Data.sln    # .NET solution
├── build.yml           # CI build pipeline
├── docfx.json          # DocFX configuration
├── LICENSE
└── README.md
```

---

## 🧠 Features

### 📌 Strongly-Typed Game Data
- Item definitions
- Prefabs and internal object names
- Recipes and crafting data
- Localization strings
- Creature and NPC references

Designed to reflect Valheim’s internal data structures as closely as possible.

---

### 📚 Documentation via DocFX
- Generates a static documentation site
- API references and data listings
- Keeps documentation aligned with the source code

---

### 🧪 Unit Tests
- Ensures data models stay valid
- Prevents regressions when updating data or schemas
- Encourages safe contributions

---

## 🛠 Getting Started

### 📦 Prerequisites

| Tool | Version |
|-----|--------|
| .NET SDK | 7.0 or newer |
| Git | Latest |
| DocFX | Latest (optional, for docs) |

---

### 📥 Clone the Repository

```bash
git clone https://github.com/lancer1977/Valheim.Data.git
cd Valheim.Data
```

---

### 🔧 Build the Project

```bash
dotnet restore
dotnet build
```

---

### 🧪 Run Tests

```bash
dotnet test
```

---

## 📘 Documentation

Documentation is generated using **DocFX**.

To build and preview locally:

```bash
docfx docs/docfx.json --serve
```

Then open:

```
http://localhost:8080
```

The documentation includes:
- API references
- Data models
- Usage examples

---

## 🧠 Example Use Cases

- 🎮 **Mod Development**  
  Use typed game data instead of hard-coded strings.

- 🔗 **Server APIs**  
  Power REST or SignalR services with consistent Valheim data.

- 📊 **Dashboards & Tools**  
  Build admin panels or monitoring tools using game metadata.

- 📦 **Shared Libraries**  
  Publish as a NuGet package for reuse across projects.

---

## 🤝 Contributing

Contributions are welcome!

1. Fork the repository
2. Create a feature branch  
   ```bash
   git checkout -b feature/my-feature
   ```
3. Commit your changes
4. Open a Pull Request

Please include:
- Tests for new functionality
- Documentation updates where applicable

---

## ⚠️ Notes on Game Versions

Valheim updates may change internal data formats or names.

Best practices:
- Track Valheim version compatibility
- Update models incrementally
- Validate changes with tests

---

## 📜 License

This project is licensed under the **MIT License**.  
See the [LICENSE](LICENSE) file for full details.

---

## ❓ Support & Questions

If you have questions or issues:
- Open a GitHub Issue
- Provide reproduction steps when applicable
- Include Valheim version details if relevant

---

Happy modding! ⚔️
