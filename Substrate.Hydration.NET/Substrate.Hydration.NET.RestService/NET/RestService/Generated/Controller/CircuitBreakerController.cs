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
    /// CircuitBreakerController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class CircuitBreakerController : ControllerBase
    {
        
        private ICircuitBreakerStorage _circuitBreakerStorage;
        
        /// <summary>
        /// CircuitBreakerController constructor.
        /// </summary>
        public CircuitBreakerController(ICircuitBreakerStorage circuitBreakerStorage)
        {
            _circuitBreakerStorage = circuitBreakerStorage;
        }
        
        /// <summary>
        /// >> TradeVolumeLimitPerAsset
        ///  Trade volume limits of assets set by set_trade_volume_limit.
        ///  If not set, returns the default limit.
        /// </summary>
        [HttpGet("TradeVolumeLimitPerAsset")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.CircuitBreakerStorage), "TradeVolumeLimitPerAssetParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetTradeVolumeLimitPerAsset(string key)
        {
            return this.Ok(_circuitBreakerStorage.GetTradeVolumeLimitPerAsset(key));
        }
        
        /// <summary>
        /// >> AllowedTradeVolumeLimitPerAsset
        ///  Trade volumes per asset
        /// </summary>
        [HttpGet("AllowedTradeVolumeLimitPerAsset")]
        [ProducesResponseType(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_circuit_breaker.TradeVolumeLimit), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.CircuitBreakerStorage), "AllowedTradeVolumeLimitPerAssetParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetAllowedTradeVolumeLimitPerAsset(string key)
        {
            return this.Ok(_circuitBreakerStorage.GetAllowedTradeVolumeLimitPerAsset(key));
        }
        
        /// <summary>
        /// >> LiquidityAddLimitPerAsset
        ///  Liquidity limits of assets for adding liquidity.
        ///  If not set, returns the default limit.
        /// </summary>
        [HttpGet("LiquidityAddLimitPerAsset")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.CircuitBreakerStorage), "LiquidityAddLimitPerAssetParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetLiquidityAddLimitPerAsset(string key)
        {
            return this.Ok(_circuitBreakerStorage.GetLiquidityAddLimitPerAsset(key));
        }
        
        /// <summary>
        /// >> AllowedAddLiquidityAmountPerAsset
        ///  Add liquidity volumes per asset
        /// </summary>
        [HttpGet("AllowedAddLiquidityAmountPerAsset")]
        [ProducesResponseType(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_circuit_breaker.LiquidityLimit), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.CircuitBreakerStorage), "AllowedAddLiquidityAmountPerAssetParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetAllowedAddLiquidityAmountPerAsset(string key)
        {
            return this.Ok(_circuitBreakerStorage.GetAllowedAddLiquidityAmountPerAsset(key));
        }
        
        /// <summary>
        /// >> LiquidityRemoveLimitPerAsset
        ///  Liquidity limits of assets for removing liquidity.
        ///  If not set, returns the default limit.
        /// </summary>
        [HttpGet("LiquidityRemoveLimitPerAsset")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.CircuitBreakerStorage), "LiquidityRemoveLimitPerAssetParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetLiquidityRemoveLimitPerAsset(string key)
        {
            return this.Ok(_circuitBreakerStorage.GetLiquidityRemoveLimitPerAsset(key));
        }
        
        /// <summary>
        /// >> AllowedRemoveLiquidityAmountPerAsset
        ///  Remove liquidity volumes per asset
        /// </summary>
        [HttpGet("AllowedRemoveLiquidityAmountPerAsset")]
        [ProducesResponseType(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_circuit_breaker.LiquidityLimit), 200)]
        [StorageKeyBuilder(typeof(Substrate.Hydration.NET.NetApiExt.Generated.Storage.CircuitBreakerStorage), "AllowedRemoveLiquidityAmountPerAssetParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetAllowedRemoveLiquidityAmountPerAsset(string key)
        {
            return this.Ok(_circuitBreakerStorage.GetAllowedRemoveLiquidityAmountPerAsset(key));
        }
    }
}
