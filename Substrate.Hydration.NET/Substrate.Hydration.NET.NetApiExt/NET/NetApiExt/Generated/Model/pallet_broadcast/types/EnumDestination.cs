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


namespace Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_broadcast.types
{
    
    
    /// <summary>
    /// >> Destination
    /// </summary>
    public enum Destination
    {
        
        /// <summary>
        /// >> Account
        /// </summary>
        Account = 0,
        
        /// <summary>
        /// >> Burned
        /// </summary>
        Burned = 1,
    }
    
    /// <summary>
    /// >> 484 - Variant[pallet_broadcast.types.Destination]
    /// </summary>
    public sealed class EnumDestination : BaseEnumRust<Destination>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumDestination()
        {
				AddTypeDecoder<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(Destination.Account);
				AddTypeDecoder<BaseVoid>(Destination.Burned);
        }
    }
}
