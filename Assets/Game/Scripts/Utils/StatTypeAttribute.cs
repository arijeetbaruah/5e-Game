using System;

namespace Game.Utils
{
    /// <summary>
    /// Attribute for stat type dropdown
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class StatTypeAttribute : System.Attribute
    {

    }
}
