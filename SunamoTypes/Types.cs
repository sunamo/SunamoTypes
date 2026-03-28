namespace SunamoTypes;

/// <summary>
/// Provides cached <see cref="Type"/> references for common .NET types.
/// </summary>
public class Types
{
    /// <summary>
    /// Cached type reference for <see cref="object"/>.
    /// </summary>
    public static readonly Type ObjectType = typeof(object);

    /// <summary>
    /// Cached type reference for <see cref="StringBuilder"/>.
    /// </summary>
    public static readonly Type StringBuilderType = typeof(StringBuilder);

    /// <summary>
    /// Cached type reference for <see cref="IEnumerable"/>.
    /// </summary>
    public static readonly Type IEnumerableType = typeof(IEnumerable);

    /// <summary>
    /// Cached type reference for <see cref="string"/>.
    /// </summary>
    public static readonly Type StringType = typeof(string);

    /// <summary>
    /// Cached type reference for <see cref="float"/>.
    /// </summary>
    public static readonly Type FloatType = typeof(float);

    /// <summary>
    /// Cached type reference for <see cref="double"/>.
    /// </summary>
    public static readonly Type DoubleType = typeof(double);

    /// <summary>
    /// Cached type reference for <see cref="int"/>.
    /// </summary>
    public static readonly Type IntType = typeof(int);

    /// <summary>
    /// Cached type reference for <see cref="long"/>.
    /// </summary>
    public static readonly Type LongType = typeof(long);

    /// <summary>
    /// Cached type reference for <see cref="short"/>.
    /// </summary>
    public static readonly Type ShortType = typeof(short);

    /// <summary>
    /// Cached type reference for <see cref="decimal"/>.
    /// </summary>
    public static readonly Type DecimalType = typeof(decimal);

    /// <summary>
    /// Cached type reference for <see cref="sbyte"/>.
    /// </summary>
    public static readonly Type SbyteType = typeof(sbyte);

    /// <summary>
    /// Cached type reference for <see cref="byte"/>.
    /// </summary>
    public static readonly Type ByteType = typeof(byte);

    /// <summary>
    /// Cached type reference for <see cref="ushort"/>.
    /// </summary>
    public static readonly Type UshortType = typeof(ushort);

    /// <summary>
    /// Cached type reference for <see cref="uint"/>.
    /// </summary>
    public static readonly Type UintType = typeof(uint);

    /// <summary>
    /// Cached type reference for <see cref="ulong"/>.
    /// </summary>
    public static readonly Type UlongType = typeof(ulong);

    /// <summary>
    /// Cached type reference for <see cref="DateTime"/>.
    /// </summary>
    public static readonly Type DateTimeType = typeof(DateTime);

    /// <summary>
    /// Cached type reference for <see cref="T:byte[]"/>.
    /// </summary>
    public static readonly Type BinaryType = typeof(byte[]);

    /// <summary>
    /// Cached type reference for <see cref="char"/>.
    /// </summary>
    public static readonly Type CharType = typeof(char);

    /// <summary>
    /// Cached type reference for <see cref="bool"/>.
    /// </summary>
    public static readonly Type BoolType = typeof(bool);

    /// <summary>
    /// Cached type reference for <see cref="Guid"/>.
    /// </summary>
    public static readonly Type GuidType = typeof(Guid);

    /// <summary>
    /// List of all basic .NET types.
    /// </summary>
    public static readonly List<Type> AllBasicTypes = new()
    {
        ObjectType, StringType, StringBuilderType, IntType, DateTimeType,
        DoubleType, FloatType, CharType, BinaryType, ByteType, ShortType, BinaryType, LongType, DecimalType, SbyteType, UshortType, UintType, UlongType
    };

    /// <summary>
    /// Cached type reference for <see cref="IList"/>.
    /// </summary>
    public static readonly Type ListType = typeof(IList);
}
