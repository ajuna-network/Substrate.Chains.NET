//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.Unique.NET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Unique.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// TreasuryController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class TreasuryController : ControllerBase
    {
        
        private ITreasuryStorage _treasuryStorage;
        
        /// <summary>
        /// TreasuryController constructor.
        /// </summary>
        public TreasuryController(ITreasuryStorage treasuryStorage)
        {
            _treasuryStorage = treasuryStorage;
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  DEPRECATED: associated with `spend_local` call and will be removed in May 2025.
        ///  Refer to <https://github.com/paritytech/polkadot-sdk/pull/5961> for migration to `spend`.
        /// 
        ///  Number of proposals that have been made.
        /// </summary>
        [HttpGet("ProposalCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Unique.NET.NetApiExt.Generated.Storage.TreasuryStorage), "ProposalCountParams")]
        public IActionResult GetProposalCount()
        {
            return this.Ok(_treasuryStorage.GetProposalCount());
        }
        
        /// <summary>
        /// >> Proposals
        ///  DEPRECATED: associated with `spend_local` call and will be removed in May 2025.
        ///  Refer to <https://github.com/paritytech/polkadot-sdk/pull/5961> for migration to `spend`.
        /// 
        ///  Proposals that have been made.
        /// </summary>
        [HttpGet("Proposals")]
        [ProducesResponseType(typeof(Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal), 200)]
        [StorageKeyBuilder(typeof(Substrate.Unique.NET.NetApiExt.Generated.Storage.TreasuryStorage), "ProposalsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetProposals(string key)
        {
            return this.Ok(_treasuryStorage.GetProposals(key));
        }
        
        /// <summary>
        /// >> Deactivated
        ///  The amount which has been reported as inactive to Currency.
        /// </summary>
        [HttpGet("Deactivated")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Substrate.Unique.NET.NetApiExt.Generated.Storage.TreasuryStorage), "DeactivatedParams")]
        public IActionResult GetDeactivated()
        {
            return this.Ok(_treasuryStorage.GetDeactivated());
        }
        
        /// <summary>
        /// >> Approvals
        ///  DEPRECATED: associated with `spend_local` call and will be removed in May 2025.
        ///  Refer to <https://github.com/paritytech/polkadot-sdk/pull/5961> for migration to `spend`.
        /// 
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        [HttpGet("Approvals")]
        [ProducesResponseType(typeof(Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT27), 200)]
        [StorageKeyBuilder(typeof(Substrate.Unique.NET.NetApiExt.Generated.Storage.TreasuryStorage), "ApprovalsParams")]
        public IActionResult GetApprovals()
        {
            return this.Ok(_treasuryStorage.GetApprovals());
        }
        
        /// <summary>
        /// >> SpendCount
        ///  The count of spends that have been made.
        /// </summary>
        [HttpGet("SpendCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Unique.NET.NetApiExt.Generated.Storage.TreasuryStorage), "SpendCountParams")]
        public IActionResult GetSpendCount()
        {
            return this.Ok(_treasuryStorage.GetSpendCount());
        }
        
        /// <summary>
        /// >> Spends
        ///  Spends that have been approved and being processed.
        /// </summary>
        [HttpGet("Spends")]
        [ProducesResponseType(typeof(Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_treasury.SpendStatus), 200)]
        [StorageKeyBuilder(typeof(Substrate.Unique.NET.NetApiExt.Generated.Storage.TreasuryStorage), "SpendsParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetSpends(string key)
        {
            return this.Ok(_treasuryStorage.GetSpends(key));
        }
        
        /// <summary>
        /// >> LastSpendPeriod
        ///  The blocknumber for the last triggered spend period.
        /// </summary>
        [HttpGet("LastSpendPeriod")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Unique.NET.NetApiExt.Generated.Storage.TreasuryStorage), "LastSpendPeriodParams")]
        public IActionResult GetLastSpendPeriod()
        {
            return this.Ok(_treasuryStorage.GetLastSpendPeriod());
        }
    }
}
