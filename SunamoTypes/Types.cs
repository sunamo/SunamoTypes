namespace SunamoTypes;

public class Types
{
    public static readonly Type ObjectType = typeof(object);
    public static readonly Type StringBuilderType = typeof(StringBuilder);
    public static readonly Type IEnumerableType = typeof(IEnumerable);
    public static readonly Type StringType = typeof(string);
    public static readonly Type FloatType = typeof(float);
    public static readonly Type DoubleType = typeof(double);
    public static readonly Type IntType = typeof(int);
    public static readonly Type LongType = typeof(long);
    public static readonly Type ShortType = typeof(short);
    public static readonly Type DecimalType = typeof(decimal);
    public static readonly Type SbyteType = typeof(sbyte);
    public static readonly Type ByteType = typeof(byte);
    public static readonly Type UshortType = typeof(ushort);
    public static readonly Type UintType = typeof(uint);
    public static readonly Type UlongType = typeof(ulong);
    public static readonly Type DateTimeType = typeof(DateTime);
    public static readonly Type BinaryType = typeof(byte[]);
    public static readonly Type CharType = typeof(char);
    public static readonly Type BoolType = typeof(bool);
    public static readonly Type GuidType = typeof(Guid);

    public static readonly List<Type> AllBasicTypes = new()
    {
        ObjectType, StringType, StringBuilderType, IntType, DateTimeType,
        DoubleType, FloatType, CharType, BinaryType, ByteType, ShortType, BinaryType, LongType, DecimalType, SbyteType, UshortType, UintType, UlongType
    };

    public static readonly Type ListType = typeof(IList);
}
