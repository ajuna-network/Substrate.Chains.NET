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


namespace Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_democracy.vote
{
    
    
    /// <summary>
    /// >> AccountVote
    /// </summary>
    public enum AccountVote
    {
        
        /// <summary>
        /// >> Standard
        /// </summary>
        Standard = 0,
        
        /// <summary>
        /// >> Split
        /// </summary>
        Split = 1,
    }
    
    /// <summary>
    /// >> 44 - Variant[pallet_democracy.vote.AccountVote]
    /// </summary>
    public sealed class EnumAccountVote : BaseEnumRust<AccountVote>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumAccountVote()
        {
				AddTypeDecoder<BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_democracy.vote.Vote, Substrate.NetApi.Model.Types.Primitive.U128>>(AccountVote.Standard);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(AccountVote.Split);
        }
    }
}
