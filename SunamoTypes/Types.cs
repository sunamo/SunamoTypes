namespace SunamoTypes;

/// <summary>
/// Represents the types type.
/// </summary>
public class Types
{
    /// <summary>
    /// The object type.
    /// </summary>
    public static readonly Type ObjectType = typeof(object);
    /// <summary>
    /// The string builder type.
    /// </summary>
    public static readonly Type StringBuilderType = typeof(StringBuilder);
    /// <summary>
    /// The i enumerable type.
    /// </summary>
    public static readonly Type IEnumerableType = typeof(IEnumerable);
    /// <summary>
    /// The string type.
    /// </summary>
    public static readonly Type StringType = typeof(string);
    /// <summary>
    /// The float type.
    /// </summary>
    public static readonly Type FloatType = typeof(float);
    /// <summary>
    /// The double type.
    /// </summary>
    public static readonly Type DoubleType = typeof(double);
    /// <summary>
    /// The int type.
    /// </summary>
    public static readonly Type IntType = typeof(int);
    /// <summary>
    /// The long type.
    /// </summary>
    public static readonly Type LongType = typeof(long);
    /// <summary>
    /// The short type.
    /// </summary>
    public static readonly Type ShortType = typeof(short);
    /// <summary>
    /// The decimal type.
    /// </summary>
    public static readonly Type DecimalType = typeof(decimal);
    /// <summary>
    /// The sbyte type.
    /// </summary>
    public static readonly Type SbyteType = typeof(sbyte);
    /// <summary>
    /// The byte type.
    /// </summary>
    public static readonly Type ByteType = typeof(byte);
    /// <summary>
    /// The ushort type.
    /// </summary>
    public static readonly Type UshortType = typeof(ushort);
    /// <summary>
    /// The uint type.
    /// </summary>
    public static readonly Type UintType = typeof(uint);
    /// <summary>
    /// The ulong type.
    /// </summary>
    public static readonly Type UlongType = typeof(ulong);
    /// <summary>
    /// The date time type.
    /// </summary>
    public static readonly Type DateTimeType = typeof(DateTime);
    /// <summary>
    /// The binary type.
    /// </summary>
    public static readonly Type BinaryType = typeof(byte[]);
    /// <summary>
    /// The char type.
    /// </summary>
    public static readonly Type CharType = typeof(char);
    /// <summary>
    /// The bool type.
    /// </summary>
    public static readonly Type BoolType = typeof(bool);
    /// <summary>
    /// The guid type.
    /// </summary>
    public static readonly Type GuidType = typeof(Guid);

    /// <summary>
    /// The all basic types.
    /// </summary>
    public static readonly List<Type> AllBasicTypes = new()
    {
        ObjectType, StringType, StringBuilderType, IntType, DateTimeType,
        DoubleType, FloatType, CharType, BinaryType, ByteType, ShortType, BinaryType, LongType, DecimalType, SbyteType, UshortType, UintType, UlongType
    };

    /// <summary>
    /// The list type.
    /// </summary>
    public static readonly Type ListType = typeof(IList);
}
