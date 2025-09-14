using Intellenum;

namespace Soenneker.Quark.Enums.GlobalKeywords;

/// <summary>
/// Represents the CSS-wide keywords that can be applied to any CSS property.
/// These keywords are defined in the CSS Cascading and Inheritance specification
/// and provide standardized ways to control inheritance and property behavior.
/// </summary>
[Intellenum<string>]
public partial class GlobalKeyword
{
    /// <summary>
    /// Inherits the value of the property from its parent element.
    /// </summary>
    public static readonly GlobalKeyword Inherit = new("inherit");

    /// <summary>
    /// Applies the property's initial (default) value as defined by the CSS specification.
    /// </summary>
    public static readonly GlobalKeyword Initial = new("initial");

    /// <summary>
    /// Removes any explicit value and causes the property to act as if it were unset:
    /// it inherits if the property is naturally inherited, or otherwise uses its initial value.
    /// </summary>
    public static readonly GlobalKeyword Unset = new("unset");

    /// <summary>
    /// Rolls the property back to the value it would have had if no styles
    /// from the current style sheet or those with higher precedence had applied.
    /// </summary>
    public static readonly GlobalKeyword Revert = new("revert");

    /// <summary>
    /// Similar to <c>revert</c>, but only reverts styles from the current cascade layer.
    /// Lower-priority layers are restored as if the higher layer’s declaration were absent.
    /// </summary>
    public static readonly GlobalKeyword RevertLayer = new("revert-layer");
}