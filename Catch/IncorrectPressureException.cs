namespace Catch;
[Serializable]
internal class IncorrectPressureException : Exception
{
    public IncorrectPressureException(string massege) : base(massege) { }
}