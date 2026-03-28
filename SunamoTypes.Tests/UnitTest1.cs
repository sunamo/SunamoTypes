// variables names: ok
using System.Collections;
using System.Text;

namespace SunamoTypes.Tests;

/// <summary>
/// Unit tests for the SunamoTypes library.
/// </summary>
public class UnitTest1
{
    /// <summary>
    /// Verifies that all cached type references in <see cref="Types"/> match expected types.
    /// </summary>
    [Fact]
    public void Types_AllBasicTypesContainsExpectedTypes()
    {
        Assert.Equal(typeof(object), Types.ObjectType);
        Assert.Equal(typeof(string), Types.StringType);
        Assert.Equal(typeof(int), Types.IntType);
        Assert.Equal(typeof(long), Types.LongType);
        Assert.Equal(typeof(double), Types.DoubleType);
        Assert.Equal(typeof(float), Types.FloatType);
        Assert.Equal(typeof(bool), Types.BoolType);
        Assert.Equal(typeof(char), Types.CharType);
        Assert.Equal(typeof(DateTime), Types.DateTimeType);
        Assert.Equal(typeof(Guid), Types.GuidType);
        Assert.Equal(typeof(decimal), Types.DecimalType);
        Assert.Equal(typeof(byte), Types.ByteType);
        Assert.Equal(typeof(sbyte), Types.SbyteType);
        Assert.Equal(typeof(short), Types.ShortType);
        Assert.Equal(typeof(ushort), Types.UshortType);
        Assert.Equal(typeof(uint), Types.UintType);
        Assert.Equal(typeof(ulong), Types.UlongType);
        Assert.Equal(typeof(byte[]), Types.BinaryType);
        Assert.Equal(typeof(StringBuilder), Types.StringBuilderType);
        Assert.Equal(typeof(IEnumerable), Types.IEnumerableType);
        Assert.Equal(typeof(IList), Types.ListType);
        Assert.NotEmpty(Types.AllBasicTypes);
    }

    /// <summary>
    /// Verifies that delegate type references are correct.
    /// </summary>
    [Fact]
    public void TypesDelegates_ActionAndFuncTaskTypesAreCorrect()
    {
        Assert.Equal(typeof(Action), TypesDelegates.ActionType);
        Assert.Equal(typeof(Func<Task>), TypesDelegates.FuncTaskType);
    }

    /// <summary>
    /// Verifies that list type references are correct.
    /// </summary>
    [Fact]
    public void TypesList_ListTypesAreCorrect()
    {
        Assert.Equal(typeof(List<long>), TypesList.LongType);
        Assert.Equal(typeof(List<string>), TypesList.StringType);
    }
}
