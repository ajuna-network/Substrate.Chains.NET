//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.Hydration.NET.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Hydration.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ReferralsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ReferralsController : ControllerBase
    {
        
        private IReferralsStorage _referralsStorage;
        
        /// <summary>
        /// ReferralsController constructor.
        /// </summary>
        public ReferralsController(IReferralsStorage referralsStorage)
        {
            _referralsStorage = referralsStorage;
        }
        
        /// <summary>
        /// >> ReferralCodes
        ///  Referral codes
        ///  Maps a referral code to an account.
        /// </summary>
        [HttpGet("ReferralCodes")]
        [ProducesResponseType(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "ReferralCodesParams", typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14))]
        public IActionResult GetReferralCodes(string key)
        {
            return this.Ok(_referralsStorage.GetReferralCodes(key));
        }
        
        /// <summary>
        /// >> ReferralAccounts
        ///  Referral accounts
        ///  Maps an account to a referral code.
        /// </summary>
        [HttpGet("ReferralAccounts")]
        [ProducesResponseType(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT14), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "ReferralAccountsParams", typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetReferralAccounts(string key)
        {
            return this.Ok(_referralsStorage.GetReferralAccounts(key));
        }
        
        /// <summary>
        /// >> LinkedAccounts
        ///  Linked accounts.
        ///  Maps an account to a referral account.
        /// </summary>
        [HttpGet("LinkedAccounts")]
        [ProducesResponseType(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "LinkedAccountsParams", typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetLinkedAccounts(string key)
        {
            return this.Ok(_referralsStorage.GetLinkedAccounts(key));
        }
        
        /// <summary>
        /// >> ReferrerShares
        ///  Shares of a referral account
        /// </summary>
        [HttpGet("ReferrerShares")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "ReferrerSharesParams", typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetReferrerShares(string key)
        {
            return this.Ok(_referralsStorage.GetReferrerShares(key));
        }
        
        /// <summary>
        /// >> TraderShares
        ///  Shares of a trader account
        /// </summary>
        [HttpGet("TraderShares")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "TraderSharesParams", typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetTraderShares(string key)
        {
            return this.Ok(_referralsStorage.GetTraderShares(key));
        }
        
        /// <summary>
        /// >> TotalShares
        ///  Total share issuance.
        /// </summary>
        [HttpGet("TotalShares")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "TotalSharesParams")]
        public IActionResult GetTotalShares()
        {
            return this.Ok(_referralsStorage.GetTotalShares());
        }
        
        /// <summary>
        /// >> Referrer
        ///  Referer level and total accumulated rewards over time.
        ///  Maps referrer account to (Level, Balance). Level indicates current rewards and Balance is used to unlock next level.
        ///  Dev note: we use OptionQuery here because this helps to easily determine that an account if referrer account.
        /// </summary>
        [HttpGet("Referrer")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_referrals.EnumLevel, Substrate.NetApi.Model.Types.Primitive.U128>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "ReferrerParams", typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetReferrer(string key)
        {
            return this.Ok(_referralsStorage.GetReferrer(key));
        }
        
        /// <summary>
        /// >> AssetRewards
        ///  Asset fee distribution rewards information.
        ///  Maps (asset_id, level) to asset reward percentages.
        /// </summary>
        [HttpGet("AssetRewards")]
        [ProducesResponseType(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_referrals.FeeDistribution), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "AssetRewardsParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_referrals.EnumLevel>))]
        public IActionResult GetAssetRewards(string key)
        {
            return this.Ok(_referralsStorage.GetAssetRewards(key));
        }
        
        /// <summary>
        /// >> PendingConversions
        ///  Information about assets that are currently in the rewards pot.
        ///  Used to easily determine list of assets that need to be converted.
        /// </summary>
        [HttpGet("PendingConversions")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "PendingConversionsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetPendingConversions(string key)
        {
            return this.Ok(_referralsStorage.GetPendingConversions(key));
        }
        
        /// <summary>
        /// >> CounterForPendingConversions
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForPendingConversions")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.ReferralsStorage), "CounterForPendingConversionsParams")]
        public IActionResult GetCounterForPendingConversions()
        {
            return this.Ok(_referralsStorage.GetCounterForPendingConversions());
        }
    }
}
