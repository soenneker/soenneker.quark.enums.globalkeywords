[![](https://img.shields.io/nuget/v/soenneker.quark.enums.globalkeywords.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.globalkeywords/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.globalkeywords/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.globalkeywords/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.globalkeywords.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.globalkeywords/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.globalkeywords/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.globalkeywords/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.GlobalKeywords

Represents the CSS-wide keywords that can be applied to any CSS property. These keywords are defined in the CSS Cascading and Inheritance specification and provide standardized ways to control inheritance and property behavior.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.GlobalKeywords
```

## What you get

- `GlobalKeyword` — Represents the CSS-wide keywords that can be applied to any CSS property. These keywords are defined in the CSS Cascading and Inheritance specification and provide standardized ways to control inheritance and property behavior.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `GlobalKeyword.Inherit` | Inherits the value of the property from its parent element. | Inherits the value of the property from its parent element. |
| `GlobalKeyword.Initial` | Applies the property's initial (default) value as defined by the CSS specification. | Applies the property's initial (default) value as defined by the CSS specification. |
| `GlobalKeyword.Unset` | Removes any explicit value and causes the property to act as if it were unset: it inherits if the property is naturally inherited, or otherwise uses its initial value. | Removes any explicit value and causes the property to act as if it were unset: it inherits if the property is naturally inherited, or otherwise uses its initial value. |
| `GlobalKeyword.Revert` | Rolls the property back to the value it would have had if no styles from the current style sheet or those with higher precedence had applied. | Rolls the property back to the value it would have had if no styles from the current style sheet or those with higher precedence had applied. |
| `GlobalKeyword.RevertLayer` | Similar to `revert`, but only reverts styles from the current cascade layer. Lower-priority layers are restored as if the higher layer’s declaration were absent. | Similar to `revert`, but only reverts styles from the current cascade layer. Lower-priority layers are restored as if the higher layer’s declaration were absent. |
