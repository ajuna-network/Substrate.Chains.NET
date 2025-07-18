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


namespace Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_route_executor.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> sell
        /// Executes a sell with a series of trades specified in the route.
        /// The price for each trade is determined by the corresponding AMM.
        /// 
        /// - `origin`: The executor of the trade
        /// - `asset_in`: The identifier of the asset to sell
        /// - `asset_out`: The identifier of the asset to receive
        /// - `amount_in`: The amount of `asset_in` to sell
        /// - `min_amount_out`: The minimum amount of `asset_out` to receive.
        /// - `route`: Series of [`Trade<AssetId>`] to be executed. A [`Trade<AssetId>`] specifies the asset pair (`asset_in`, `asset_out`) and the AMM (`pool`) in which the trade is executed.
        /// 		   If not specified, than the on-chain route is used.
        /// 		   If no on-chain is present, then omnipool route is used as default
        /// 
        /// Emits `RouteExecuted` when successful.
        /// </summary>
        sell = 0,
        
        /// <summary>
        /// >> buy
        /// Executes a buy with a series of trades specified in the route.
        /// The price for each trade is determined by the corresponding AMM.
        /// 
        /// - `origin`: The executor of the trade
        /// - `asset_in`: The identifier of the asset to be swapped to buy `asset_out`
        /// - `asset_out`: The identifier of the asset to buy
        /// - `amount_out`: The amount of `asset_out` to buy
        /// - `max_amount_in`: The max amount of `asset_in` to spend on the buy.
        /// - `route`: Series of [`Trade<AssetId>`] to be executed. A [`Trade<AssetId>`] specifies the asset pair (`asset_in`, `asset_out`) and the AMM (`pool`) in which the trade is executed.
        /// 		   If not specified, than the on-chain route is used.
        /// 		   If no on-chain is present, then omnipool route is used as default
        /// 
        /// Emits `RouteExecuted` when successful.
        /// </summary>
        buy = 1,
        
        /// <summary>
        /// >> set_route
        /// Sets the on-chain route for a given asset pair.
        /// 
        /// The new route is validated by being executed in a dry-run mode
        /// 
        /// If there is no route explicitly set for an asset pair, then we use the omnipool route as default.
        /// 
        /// When a new route is set, we compare it to the existing (or default) route.
        /// The comparison happens by calculating sell amount_outs for the routes, but also for the inversed routes.
        /// 
        /// The route is stored in an ordered manner, based on the oder of the ids in the asset pair.
        /// 
        /// If the route is set successfully, then the fee is payed back.
        /// 
        /// - `origin`: The origin of the route setter
        /// - `asset_pair`: The identifier of the asset-pair for which the route is set
        /// - `new_route`: Series of [`Trade<AssetId>`] to be executed. A [`Trade<AssetId>`] specifies the asset pair (`asset_in`, `asset_out`) and the AMM (`pool`) in which the trade is executed.
        /// 
        /// Emits `RouteUpdated` when successful.
        /// 
        /// Fails with `RouteUpdateIsNotSuccessful` error when failed to set the route
        /// 
        /// </summary>
        set_route = 2,
        
        /// <summary>
        /// >> force_insert_route
        /// Force inserts the on-chain route for a given asset pair, so there is no any validation for the route
        /// 
        /// Can only be called by T::ForceInsertOrigin
        /// 
        /// The route is stored in an ordered manner, based on the oder of the ids in the asset pair.
        /// 
        /// If the route is set successfully, then the fee is payed back.
        /// 
        /// - `origin`: The origin of the route setter
        /// - `asset_pair`: The identifier of the asset-pair for which the route is set
        /// - `new_route`: Series of [`Trade<AssetId>`] to be executed. A [`Trade<AssetId>`] specifies the asset pair (`asset_in`, `asset_out`) and the AMM (`pool`) in which the trade is executed.
        /// 
        /// Emits `RouteUpdated` when successful.
        /// 
        /// </summary>
        force_insert_route = 3,
        
        /// <summary>
        /// >> sell_all
        /// Executes a sell with a series of trades specified in the route.
        /// It sells all reducible user balance of `asset_in`
        /// The price for each trade is determined by the corresponding AMM.
        /// 
        /// - `origin`: The executor of the trade
        /// - `asset_in`: The identifier of the asset to sell
        /// - `asset_out`: The identifier of the asset to receive
        /// - `min_amount_out`: The minimum amount of `asset_out` to receive.
        /// - `route`: Series of [`Trade<AssetId>`] to be executed. A [`Trade<AssetId>`] specifies the asset pair (`asset_in`, `asset_out`) and the AMM (`pool`) in which the trade is executed.
        /// 		   If not specified, than the on-chain route is used.
        /// 		   If no on-chain is present, then omnipool route is used as default
        /// 
        /// Emits `RouteExecuted` when successful.
        /// 
        /// </summary>
        sell_all = 4,
    }
    
    /// <summary>
    /// >> 232 - Variant[pallet_route_executor.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11>>(Call.sell);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11>>(Call.buy);
				AddTypeDecoder<BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.hydradx_traits.router.AssetPair, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11>>(Call.set_route);
				AddTypeDecoder<BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.hydradx_traits.router.AssetPair, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11>>(Call.force_insert_route);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11>>(Call.sell_all);
        }
    }
}
