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


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_ethereum
{
    
    
    /// <summary>
    /// >> RawOrigin
    /// </summary>
    public enum RawOrigin
    {
        
        /// <summary>
        /// >> EthereumTransaction
        /// </summary>
        EthereumTransaction = 0,
    }
    
    /// <summary>
    /// >> 235 - Variant[pallet_ethereum.RawOrigin]
    /// </summary>
    public sealed class EnumRawOrigin : BaseEnumRust<RawOrigin>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRawOrigin()
        {
				AddTypeDecoder<Substrate.Unique.NET.NetApiExt.Generated.Model.primitive_types.H160>(RawOrigin.EthereumTransaction);
        }
    }
}
