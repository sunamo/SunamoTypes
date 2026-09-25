namespace SunamoTypes;

/// <summary>
/// Provides cached <see cref="Type"/> references for generic <see cref="List{T}"/> types.
/// </summary>
public class TypesList
{
    /// <summary>
    /// Cached type reference for <see cref="List{T}"/> of <see cref="long"/>.
    /// </summary>
    public static readonly Type LongType = typeof(List<long>);

    /// <summary>
    /// Cached type reference for <see cref="List{T}"/> of <see cref="string"/>.
    /// </summary>
    public static readonly Type StringType = typeof(List<string>);
}
