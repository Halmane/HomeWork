using System.Runtime.Serialization;

namespace Catch
{
    [Serializable]
    internal class TooLowPressureException : Exception
    {
        public TooLowPressureException(string massege) : base(massege) { }
    }
}