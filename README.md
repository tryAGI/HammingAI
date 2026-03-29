# HammingAI

[![Nuget package](https://img.shields.io/nuget/vpre/HammingAI)](https://www.nuget.org/packages/HammingAI/)
[![dotnet](https://github.com/tryAGI/HammingAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/HammingAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/HammingAI)](https://github.com/tryAGI/HammingAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [Hamming AI](https://hamming.ai/) API using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Voice agent testing, evaluation, and production monitoring
- Supports Vapi, RetellAI, Bland, LiveKit, and other voice agent platforms
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- MEAI `AIFunction` tools for integration with any `IChatClient`

### Usage
```csharp
using HammingAI;

using var client = new HammingAIClient(apiKey);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/HammingAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/HammingAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
