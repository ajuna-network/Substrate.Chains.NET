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


namespace Substrate.Hydration.NET.NetApiExt.Generated.Model.staging_xcm.v4.asset
{
    
    
    /// <summary>
    /// >> AssetFilter
    /// </summary>
    public enum AssetFilter
    {
        
        /// <summary>
        /// >> Definite
        /// </summary>
        Definite = 0,
        
        /// <summary>
        /// >> Wild
        /// </summary>
        Wild = 1,
    }
    
    /// <summary>
    /// >> 376 - Variant[staging_xcm.v4.asset.AssetFilter]
    /// </summary>
    public sealed class EnumAssetFilter : BaseEnumRust<AssetFilter>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumAssetFilter()
        {
				AddTypeDecoder<Substrate.Hydration.NET.NetApiExt.Generated.Model.staging_xcm.v4.asset.Assets>(AssetFilter.Definite);
				AddTypeDecoder<Substrate.Hydration.NET.NetApiExt.Generated.Model.staging_xcm.v4.asset.EnumWildAsset>(AssetFilter.Wild);
        }
    }
}
