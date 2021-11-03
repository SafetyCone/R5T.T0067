using System;


namespace R5T.T0067
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Service : IService
    {
        #region Static
        
        public static Service Instance { get; } = new();

        #endregion
    }
}