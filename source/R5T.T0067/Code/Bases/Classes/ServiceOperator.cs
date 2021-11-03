using System;


namespace R5T.T0067
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceOperator : IServiceOperator
    {
        #region Static
        
        public static ServiceOperator Instance { get; } = new();

        #endregion
    }
}