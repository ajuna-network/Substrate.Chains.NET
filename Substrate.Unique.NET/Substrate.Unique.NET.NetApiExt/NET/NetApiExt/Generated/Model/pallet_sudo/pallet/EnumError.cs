//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_sudo.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// Error for the Sudo pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> RequireSudo
        /// Sender must be the Sudo account.
        /// </summary>
        RequireSudo = 0,
    }
    
    /// <summary>
    /// >> 522 - Variant[pallet_sudo.pallet.Error]
    /// Error for the Sudo pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
