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


namespace Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_uniques.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Created
        /// A `collection` was created.
        /// </summary>
        Created = 0,
        
        /// <summary>
        /// >> ForceCreated
        /// A `collection` was force-created.
        /// </summary>
        ForceCreated = 1,
        
        /// <summary>
        /// >> Destroyed
        /// A `collection` was destroyed.
        /// </summary>
        Destroyed = 2,
        
        /// <summary>
        /// >> Issued
        /// An `item` was issued.
        /// </summary>
        Issued = 3,
        
        /// <summary>
        /// >> Transferred
        /// An `item` was transferred.
        /// </summary>
        Transferred = 4,
        
        /// <summary>
        /// >> Burned
        /// An `item` was destroyed.
        /// </summary>
        Burned = 5,
        
        /// <summary>
        /// >> Frozen
        /// Some `item` was frozen.
        /// </summary>
        Frozen = 6,
        
        /// <summary>
        /// >> Thawed
        /// Some `item` was thawed.
        /// </summary>
        Thawed = 7,
        
        /// <summary>
        /// >> CollectionFrozen
        /// Some `collection` was frozen.
        /// </summary>
        CollectionFrozen = 8,
        
        /// <summary>
        /// >> CollectionThawed
        /// Some `collection` was thawed.
        /// </summary>
        CollectionThawed = 9,
        
        /// <summary>
        /// >> OwnerChanged
        /// The owner changed.
        /// </summary>
        OwnerChanged = 10,
        
        /// <summary>
        /// >> TeamChanged
        /// The management team changed.
        /// </summary>
        TeamChanged = 11,
        
        /// <summary>
        /// >> ApprovedTransfer
        /// An `item` of a `collection` has been approved by the `owner` for transfer by
        /// a `delegate`.
        /// </summary>
        ApprovedTransfer = 12,
        
        /// <summary>
        /// >> ApprovalCancelled
        /// An approval for a `delegate` account to transfer the `item` of an item
        /// `collection` was cancelled by its `owner`.
        /// </summary>
        ApprovalCancelled = 13,
        
        /// <summary>
        /// >> ItemStatusChanged
        /// A `collection` has had its attributes changed by the `Force` origin.
        /// </summary>
        ItemStatusChanged = 14,
        
        /// <summary>
        /// >> CollectionMetadataSet
        /// New metadata has been set for a `collection`.
        /// </summary>
        CollectionMetadataSet = 15,
        
        /// <summary>
        /// >> CollectionMetadataCleared
        /// Metadata has been cleared for a `collection`.
        /// </summary>
        CollectionMetadataCleared = 16,
        
        /// <summary>
        /// >> MetadataSet
        /// New metadata has been set for an item.
        /// </summary>
        MetadataSet = 17,
        
        /// <summary>
        /// >> MetadataCleared
        /// Metadata has been cleared for an item.
        /// </summary>
        MetadataCleared = 18,
        
        /// <summary>
        /// >> Redeposited
        /// Metadata has been cleared for an item.
        /// </summary>
        Redeposited = 19,
        
        /// <summary>
        /// >> AttributeSet
        /// New attribute metadata has been set for a `collection` or `item`.
        /// </summary>
        AttributeSet = 20,
        
        /// <summary>
        /// >> AttributeCleared
        /// Attribute metadata has been cleared for a `collection` or `item`.
        /// </summary>
        AttributeCleared = 21,
        
        /// <summary>
        /// >> OwnershipAcceptanceChanged
        /// Ownership acceptance has changed for an account.
        /// </summary>
        OwnershipAcceptanceChanged = 22,
        
        /// <summary>
        /// >> CollectionMaxSupplySet
        /// Max supply has been set for a collection.
        /// </summary>
        CollectionMaxSupplySet = 23,
        
        /// <summary>
        /// >> ItemPriceSet
        /// The price was set for the instance.
        /// </summary>
        ItemPriceSet = 24,
        
        /// <summary>
        /// >> ItemPriceRemoved
        /// The price for the instance was removed.
        /// </summary>
        ItemPriceRemoved = 25,
        
        /// <summary>
        /// >> ItemBought
        /// An item was bought.
        /// </summary>
        ItemBought = 26,
    }
    
    /// <summary>
    /// >> 58 - Variant[pallet_uniques.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.Created);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.ForceCreated);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Event.Destroyed);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.Issued);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.Transferred);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.Burned);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Frozen);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Thawed);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Event.CollectionFrozen);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Event.CollectionThawed);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.OwnerChanged);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.TeamChanged);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.ApprovedTransfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.ApprovalCancelled);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Event.ItemStatusChanged);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2, Substrate.NetApi.Model.Types.Primitive.Bool>>(Event.CollectionMetadataSet);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Event.CollectionMetadataCleared);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2, Substrate.NetApi.Model.Types.Primitive.Bool>>(Event.MetadataSet);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.MetadataCleared);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U128>>>(Event.Redeposited);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4>>(Event.AttributeSet);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3>>(Event.AttributeCleared);
				AddTypeDecoder<BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>>>(Event.OwnershipAcceptanceChanged);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.CollectionMaxSupplySet);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>>(Event.ItemPriceSet);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.ItemPriceRemoved);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(Event.ItemBought);
        }
    }
}
