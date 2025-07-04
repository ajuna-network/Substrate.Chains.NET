//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Unique.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IFellowshipReferendaStorage interface definition.
    /// </summary>
    public interface IFellowshipReferendaStorage : IStorage
    {
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetReferendumCount();
        
        /// <summary>
        /// >> ReferendumInfoFor
        ///  Information concerning any given referendum.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo GetReferendumInfoFor(string key);
        
        /// <summary>
        /// >> TrackQueue
        ///  The sorted list of referenda ready to be decided but not yet being decided, ordered by
        ///  conviction-weighted approvals.
        /// 
        ///  This should be empty if `DecidingCount` is less than `TrackInfo::max_deciding`.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40 GetTrackQueue(string key);
        
        /// <summary>
        /// >> DecidingCount
        ///  The number of referenda being decided currently.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetDecidingCount(string key);
        
        /// <summary>
        /// >> MetadataOf
        ///  The metadata is a general information concerning the referendum.
        ///  The `Hash` refers to the preimage of the `Preimages` provider which can be a JSON
        ///  dump or IPFS hash of a JSON file.
        /// 
        ///  Consider a garbage collection for a metadata of finished referendums to `unrequest` (remove)
        ///  large preimages.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.primitive_types.H256 GetMetadataOf(string key);
    }
    
    /// <summary>
    /// FellowshipReferendaStorage class definition.
    /// </summary>
    public sealed class FellowshipReferendaStorage : IFellowshipReferendaStorage
    {
        
        /// <summary>
        /// _referendumCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _referendumCountTypedStorage;
        
        /// <summary>
        /// _referendumInfoForTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo> _referendumInfoForTypedStorage;
        
        /// <summary>
        /// _trackQueueTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40> _trackQueueTypedStorage;
        
        /// <summary>
        /// _decidingCountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _decidingCountTypedStorage;
        
        /// <summary>
        /// _metadataOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.primitive_types.H256> _metadataOfTypedStorage;
        
        /// <summary>
        /// FellowshipReferendaStorage constructor.
        /// </summary>
        public FellowshipReferendaStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ReferendumCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("FellowshipReferenda.ReferendumCount", storageDataProvider, storageChangeDelegates);
            this.ReferendumInfoForTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo>("FellowshipReferenda.ReferendumInfoFor", storageDataProvider, storageChangeDelegates);
            this.TrackQueueTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40>("FellowshipReferenda.TrackQueue", storageDataProvider, storageChangeDelegates);
            this.DecidingCountTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("FellowshipReferenda.DecidingCount", storageDataProvider, storageChangeDelegates);
            this.MetadataOfTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.primitive_types.H256>("FellowshipReferenda.MetadataOf", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _referendumCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> ReferendumCountTypedStorage
        {
            get
            {
                return _referendumCountTypedStorage;
            }
            set
            {
                _referendumCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _referendumInfoForTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo> ReferendumInfoForTypedStorage
        {
            get
            {
                return _referendumInfoForTypedStorage;
            }
            set
            {
                _referendumInfoForTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _trackQueueTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40> TrackQueueTypedStorage
        {
            get
            {
                return _trackQueueTypedStorage;
            }
            set
            {
                _trackQueueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _decidingCountTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> DecidingCountTypedStorage
        {
            get
            {
                return _decidingCountTypedStorage;
            }
            set
            {
                _decidingCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _metadataOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.primitive_types.H256> MetadataOfTypedStorage
        {
            get
            {
                return _metadataOfTypedStorage;
            }
            set
            {
                _metadataOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ReferendumCountTypedStorage.InitializeAsync("FellowshipReferenda", "ReferendumCount");
            await ReferendumInfoForTypedStorage.InitializeAsync("FellowshipReferenda", "ReferendumInfoFor");
            await TrackQueueTypedStorage.InitializeAsync("FellowshipReferenda", "TrackQueue");
            await DecidingCountTypedStorage.InitializeAsync("FellowshipReferenda", "DecidingCount");
            await MetadataOfTypedStorage.InitializeAsync("FellowshipReferenda", "MetadataOf");
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipReferenda.ReferendumCount
        /// </summary>
        [StorageChange("FellowshipReferenda", "ReferendumCount")]
        public void OnUpdateReferendumCount(string data)
        {
            ReferendumCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetReferendumCount()
        {
            return ReferendumCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipReferenda.ReferendumInfoFor
        /// </summary>
        [StorageChange("FellowshipReferenda", "ReferendumInfoFor")]
        public void OnUpdateReferendumInfoFor(string key, string data)
        {
            ReferendumInfoForTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ReferendumInfoFor
        ///  Information concerning any given referendum.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo GetReferendumInfoFor(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReferendumInfoForTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipReferenda.TrackQueue
        /// </summary>
        [StorageChange("FellowshipReferenda", "TrackQueue")]
        public void OnUpdateTrackQueue(string key, string data)
        {
            TrackQueueTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TrackQueue
        ///  The sorted list of referenda ready to be decided but not yet being decided, ordered by
        ///  conviction-weighted approvals.
        /// 
        ///  This should be empty if `DecidingCount` is less than `TrackInfo::max_deciding`.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40 GetTrackQueue(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TrackQueueTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipReferenda.DecidingCount
        /// </summary>
        [StorageChange("FellowshipReferenda", "DecidingCount")]
        public void OnUpdateDecidingCount(string key, string data)
        {
            DecidingCountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DecidingCount
        ///  The number of referenda being decided currently.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetDecidingCount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DecidingCountTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for FellowshipReferenda.MetadataOf
        /// </summary>
        [StorageChange("FellowshipReferenda", "MetadataOf")]
        public void OnUpdateMetadataOf(string key, string data)
        {
            MetadataOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> MetadataOf
        ///  The metadata is a general information concerning the referendum.
        ///  The `Hash` refers to the preimage of the `Preimages` provider which can be a JSON
        ///  dump or IPFS hash of a JSON file.
        /// 
        ///  Consider a garbage collection for a metadata of finished referendums to `unrequest` (remove)
        ///  large preimages.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.primitive_types.H256 GetMetadataOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (MetadataOfTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.primitive_types.H256 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
