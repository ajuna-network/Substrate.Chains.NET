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


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> SponsorshipState
    /// </summary>
    public enum SponsorshipState
    {
        
        /// <summary>
        /// >> Disabled
        /// </summary>
        Disabled = 0,
        
        /// <summary>
        /// >> Unconfirmed
        /// </summary>
        Unconfirmed = 1,
        
        /// <summary>
        /// >> Confirmed
        /// </summary>
        Confirmed = 2,
    }
    
    /// <summary>
    /// >> 727 - Variant[up_data_structs.SponsorshipState]
    /// </summary>
    public sealed class EnumSponsorshipState : BaseEnumRust<SponsorshipState>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumSponsorshipState()
        {
				AddTypeDecoder<BaseVoid>(SponsorshipState.Disabled);
				AddTypeDecoder<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>(SponsorshipState.Unconfirmed);
				AddTypeDecoder<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>(SponsorshipState.Confirmed);
        }
    }
}
