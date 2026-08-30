[![](https://img.shields.io/nuget/v/soenneker.quark.enums.globalkeywords.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.globalkeywords/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.globalkeywords/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.globalkeywords/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.globalkeywords/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.globalkeywords/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.globalkeywords.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.globalkeywords/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.globalkeywords/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.globalkeywords/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.GlobalKeywords

Strongly typed CSS-wide keywords that can be assigned to any CSS property.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.GlobalKeywords
```

## Usage

```csharp
GlobalKeyword keyword = GlobalKeyword.Inherit;
string cssValue = keyword.Value; // "inherit"
```

These values are also included by Quark property-specific keyword types, so a component API can accept values such as `FontStyleKeyword.Inherit` without introducing a separate string path.

## Values

| Member | CSS value | Effect |
| --- | --- | --- |
| `Inherit` | `inherit` | Uses the computed value from the parent element. |
| `Initial` | `initial` | Uses the property's specification-defined initial value. |
| `Unset` | `unset` | Behaves as `inherit` for inherited properties and `initial` otherwise. |
| `Revert` | `revert` | Rolls the property back to the value established by an earlier cascade origin. |
| `RevertLayer` | `revert-layer` | Rolls the property back within the current cascade origin to an earlier layer. |
