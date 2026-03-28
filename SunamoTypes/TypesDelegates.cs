namespace SunamoTypes;

/// <summary>
/// Provides cached <see cref="Type"/> references for delegate types.
/// </summary>
public class TypesDelegates
{
    /// <summary>
    /// Cached type reference for <see cref="Action"/>.
    /// </summary>
    public static readonly Type ActionType = typeof(Action);

    /// <summary>
    /// Cached type reference for <see cref="T:System.Func{System.Threading.Tasks.Task}"/>.
    /// </summary>
    public static readonly Type FuncTaskType = typeof(Func<Task>);
}
