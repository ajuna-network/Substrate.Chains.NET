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
    /// ICommonStorage interface definition.
    /// </summary>
    public interface ICommonStorage : IStorage
    {
        
        /// <summary>
        /// >> CreatedCollectionCount
        ///  Storage of the count of created collections. Essentially contains the last collection ID.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId GetCreatedCollectionCount();
        
        /// <summary>
        /// >> DestroyedCollectionCount
        ///  Storage of the count of deleted collections.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId GetDestroyedCollectionCount();
        
        /// <summary>
        /// >> CollectionById
        ///  Storage of collection info.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.Collection GetCollectionById(string key);
        
        /// <summary>
        /// >> CollectionProperties
        ///  Storage of collection properties.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT1 GetCollectionProperties(string key);
        
        /// <summary>
        /// >> CollectionPropertyPermissions
        ///  Storage of token property permissions of a collection.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesMapT2 GetCollectionPropertyPermissions(string key);
        
        /// <summary>
        /// >> AdminAmount
        ///  Storage of the amount of collection admins.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetAdminAmount(string key);
        
        /// <summary>
        /// >> IsAdmin
        ///  List of collection admins.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetIsAdmin(string key);
        
        /// <summary>
        /// >> Allowlist
        ///  Allowlisted collection users.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetAllowlist(string key);

        /// <summary>
        /// >> DummyStorageValue
        ///  Not used by code, exists only to provide some types to metadata.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionStats, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenChild, Substrate.Unique.NET.NetApiExt.Generated.Model.PhantomType.up_data_structs> GetDummyStorageValue();
    }
    
    /// <summary>
    /// CommonStorage class definition.
    /// </summary>
    public sealed class CommonStorage : ICommonStorage
    {
        
        /// <summary>
        /// _createdCollectionCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId> _createdCollectionCountTypedStorage;
        
        /// <summary>
        /// _destroyedCollectionCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId> _destroyedCollectionCountTypedStorage;
        
        /// <summary>
        /// _collectionByIdTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.Collection> _collectionByIdTypedStorage;
        
        /// <summary>
        /// _collectionPropertiesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT1> _collectionPropertiesTypedStorage;
        
        /// <summary>
        /// _collectionPropertyPermissionsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesMapT2> _collectionPropertyPermissionsTypedStorage;
        
        /// <summary>
        /// _adminAmountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _adminAmountTypedStorage;
        
        /// <summary>
        /// _isAdminTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _isAdminTypedStorage;
        
        /// <summary>
        /// _allowlistTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _allowlistTypedStorage;

        /// <summary>
        /// _dummyStorageValueTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionStats, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenChild, Substrate.Unique.NET.NetApiExt.Generated.Model.PhantomType.up_data_structs>> _dummyStorageValueTypedStorage;

        /// <summary>
        /// CommonStorage constructor.
        /// </summary>
        public CommonStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.CreatedCollectionCountTypedStorage = new TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId>("Common.CreatedCollectionCount", storageDataProvider, storageChangeDelegates);
            this.DestroyedCollectionCountTypedStorage = new TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId>("Common.DestroyedCollectionCount", storageDataProvider, storageChangeDelegates);
            this.CollectionByIdTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.Collection>("Common.CollectionById", storageDataProvider, storageChangeDelegates);
            this.CollectionPropertiesTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT1>("Common.CollectionProperties", storageDataProvider, storageChangeDelegates);
            this.CollectionPropertyPermissionsTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesMapT2>("Common.CollectionPropertyPermissions", storageDataProvider, storageChangeDelegates);
            this.AdminAmountTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Common.AdminAmount", storageDataProvider, storageChangeDelegates);
            this.IsAdminTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("Common.IsAdmin", storageDataProvider, storageChangeDelegates);
            this.AllowlistTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("Common.Allowlist", storageDataProvider, storageChangeDelegates);
            this.DummyStorageValueTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionStats, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenChild, Substrate.Unique.NET.NetApiExt.Generated.Model.PhantomType.up_data_structs>>("Common.DummyStorageValue", storageDataProvider, storageChangeDelegates);
        }

        /// <summary>
        /// _createdCollectionCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId> CreatedCollectionCountTypedStorage
        {
            get
            {
                return _createdCollectionCountTypedStorage;
            }
            set
            {
                _createdCollectionCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _destroyedCollectionCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId> DestroyedCollectionCountTypedStorage
        {
            get
            {
                return _destroyedCollectionCountTypedStorage;
            }
            set
            {
                _destroyedCollectionCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _collectionByIdTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.Collection> CollectionByIdTypedStorage
        {
            get
            {
                return _collectionByIdTypedStorage;
            }
            set
            {
                _collectionByIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _collectionPropertiesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT1> CollectionPropertiesTypedStorage
        {
            get
            {
                return _collectionPropertiesTypedStorage;
            }
            set
            {
                _collectionPropertiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _collectionPropertyPermissionsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesMapT2> CollectionPropertyPermissionsTypedStorage
        {
            get
            {
                return _collectionPropertyPermissionsTypedStorage;
            }
            set
            {
                _collectionPropertyPermissionsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _adminAmountTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> AdminAmountTypedStorage
        {
            get
            {
                return _adminAmountTypedStorage;
            }
            set
            {
                _adminAmountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _isAdminTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> IsAdminTypedStorage
        {
            get
            {
                return _isAdminTypedStorage;
            }
            set
            {
                _isAdminTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _allowlistTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> AllowlistTypedStorage
        {
            get
            {
                return _allowlistTypedStorage;
            }
            set
            {
                _allowlistTypedStorage = value;
            }
        }

        /// <summary>
        /// _dummyStorageValueTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionStats, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenChild, Substrate.Unique.NET.NetApiExt.Generated.Model.PhantomType.up_data_structs>> DummyStorageValueTypedStorage
        {
            get
            {
                return _dummyStorageValueTypedStorage;
            }
            set
            {
                _dummyStorageValueTypedStorage = value;
            }
        }

        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await CreatedCollectionCountTypedStorage.InitializeAsync("Common", "CreatedCollectionCount");
            await DestroyedCollectionCountTypedStorage.InitializeAsync("Common", "DestroyedCollectionCount");
            await CollectionByIdTypedStorage.InitializeAsync("Common", "CollectionById");
            await CollectionPropertiesTypedStorage.InitializeAsync("Common", "CollectionProperties");
            await CollectionPropertyPermissionsTypedStorage.InitializeAsync("Common", "CollectionPropertyPermissions");
            await AdminAmountTypedStorage.InitializeAsync("Common", "AdminAmount");
            await IsAdminTypedStorage.InitializeAsync("Common", "IsAdmin");
            await AllowlistTypedStorage.InitializeAsync("Common", "Allowlist");
            await DummyStorageValueTypedStorage.InitializeAsync("Common", "DummyStorageValue");
        }
        
        /// <summary>
        /// Implements any storage change for Common.CreatedCollectionCount
        /// </summary>
        [StorageChange("Common", "CreatedCollectionCount")]
        public void OnUpdateCreatedCollectionCount(string data)
        {
            CreatedCollectionCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CreatedCollectionCount
        ///  Storage of the count of created collections. Essentially contains the last collection ID.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId GetCreatedCollectionCount()
        {
            return CreatedCollectionCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Common.DestroyedCollectionCount
        /// </summary>
        [StorageChange("Common", "DestroyedCollectionCount")]
        public void OnUpdateDestroyedCollectionCount(string data)
        {
            DestroyedCollectionCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> DestroyedCollectionCount
        ///  Storage of the count of deleted collections.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId GetDestroyedCollectionCount()
        {
            return DestroyedCollectionCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Common.CollectionById
        /// </summary>
        [StorageChange("Common", "CollectionById")]
        public void OnUpdateCollectionById(string key, string data)
        {
            CollectionByIdTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CollectionById
        ///  Storage of collection info.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.Collection GetCollectionById(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CollectionByIdTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.Collection result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Common.CollectionProperties
        /// </summary>
        [StorageChange("Common", "CollectionProperties")]
        public void OnUpdateCollectionProperties(string key, string data)
        {
            CollectionPropertiesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CollectionProperties
        ///  Storage of collection properties.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT1 GetCollectionProperties(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CollectionPropertiesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT1 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Common.CollectionPropertyPermissions
        /// </summary>
        [StorageChange("Common", "CollectionPropertyPermissions")]
        public void OnUpdateCollectionPropertyPermissions(string key, string data)
        {
            CollectionPropertyPermissionsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CollectionPropertyPermissions
        ///  Storage of token property permissions of a collection.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesMapT2 GetCollectionPropertyPermissions(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CollectionPropertyPermissionsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesMapT2 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Common.AdminAmount
        /// </summary>
        [StorageChange("Common", "AdminAmount")]
        public void OnUpdateAdminAmount(string key, string data)
        {
            AdminAmountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AdminAmount
        ///  Storage of the amount of collection admins.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetAdminAmount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AdminAmountTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Common.IsAdmin
        /// </summary>
        [StorageChange("Common", "IsAdmin")]
        public void OnUpdateIsAdmin(string key, string data)
        {
            IsAdminTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> IsAdmin
        ///  List of collection admins.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetIsAdmin(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (IsAdminTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.Bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Common.Allowlist
        /// </summary>
        [StorageChange("Common", "Allowlist")]
        public void OnUpdateAllowlist(string key, string data)
        {
            AllowlistTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Allowlist
        ///  Allowlisted collection users.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetAllowlist(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AllowlistTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.Bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Common.DummyStorageValue
        /// </summary>
        [StorageChange("Common", "DummyStorageValue")]
        public void OnUpdateDummyStorageValue(string data)
        {
            DummyStorageValueTypedStorage.Update(data);
        }

        /// <summary>
        /// >> DummyStorageValue
        ///  Not used by code, exists only to provide some types to metadata.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionStats, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.TokenChild, Substrate.Unique.NET.NetApiExt.Generated.Model.PhantomType.up_data_structs> GetDummyStorageValue()
        {
            return DummyStorageValueTypedStorage.Get();
        }
    }
}
