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
    /// INonfungibleStorage interface definition.
    /// </summary>
    public interface INonfungibleStorage : IStorage
    {
        
        /// <summary>
        /// >> TokensMinted
        ///  Total amount of minted tokens in a collection.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetTokensMinted(string key);
        
        /// <summary>
        /// >> TokensBurnt
        ///  Amount of burnt tokens in a collection.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetTokensBurnt(string key);
        
        /// <summary>
        /// >> TokenData
        ///  Token data, used to partially describe a token.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_nonfungible.ItemData GetTokenData(string key);
        
        /// <summary>
        /// >> TokenProperties
        ///  Map of key-value pairs, describing the metadata of a token.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2 GetTokenProperties(string key);
        
        /// <summary>
        /// >> TokenAuxProperties
        ///  Custom data of a token that is serialized to bytes,
        ///  primarily reserved for on-chain operations,
        ///  normally obscured from the external users.
        /// 
        ///  Auxiliary properties are slightly different from
        ///  usual [`TokenProperties`] due to an unlimited number
        ///  and separately stored and written-to key-value pairs.
        /// 
        ///  Currently unused.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT50 GetTokenAuxProperties(string key);
        
        /// <summary>
        /// >> Owned
        ///  Used to enumerate tokens owned by account.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetOwned(string key);
        
        /// <summary>
        /// >> TokenChildren
        ///  Used to enumerate token's children.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetTokenChildren(string key);
        
        /// <summary>
        /// >> AccountBalance
        ///  Amount of tokens owned by an account in a collection.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetAccountBalance(string key);
        
        /// <summary>
        /// >> Allowance
        ///  Allowance set by a token owner for another user to perform one of certain transactions on a token.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr GetAllowance(string key);
        
        /// <summary>
        /// >> CollectionAllowance
        ///  Operator set by a wallet owner that could perform certain transactions on all tokens in the wallet.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetCollectionAllowance(string key);
    }
    
    /// <summary>
    /// NonfungibleStorage class definition.
    /// </summary>
    public sealed class NonfungibleStorage : INonfungibleStorage
    {
        
        /// <summary>
        /// _tokensMintedTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _tokensMintedTypedStorage;
        
        /// <summary>
        /// _tokensBurntTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _tokensBurntTypedStorage;
        
        /// <summary>
        /// _tokenDataTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_nonfungible.ItemData> _tokenDataTypedStorage;
        
        /// <summary>
        /// _tokenPropertiesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2> _tokenPropertiesTypedStorage;
        
        /// <summary>
        /// _tokenAuxPropertiesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT50> _tokenAuxPropertiesTypedStorage;
        
        /// <summary>
        /// _ownedTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _ownedTypedStorage;
        
        /// <summary>
        /// _tokenChildrenTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _tokenChildrenTypedStorage;
        
        /// <summary>
        /// _accountBalanceTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _accountBalanceTypedStorage;
        
        /// <summary>
        /// _allowanceTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> _allowanceTypedStorage;
        
        /// <summary>
        /// _collectionAllowanceTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _collectionAllowanceTypedStorage;
        
        /// <summary>
        /// NonfungibleStorage constructor.
        /// </summary>
        public NonfungibleStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.TokensMintedTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Nonfungible.TokensMinted", storageDataProvider, storageChangeDelegates);
            this.TokensBurntTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Nonfungible.TokensBurnt", storageDataProvider, storageChangeDelegates);
            this.TokenDataTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_nonfungible.ItemData>("Nonfungible.TokenData", storageDataProvider, storageChangeDelegates);
            this.TokenPropertiesTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2>("Nonfungible.TokenProperties", storageDataProvider, storageChangeDelegates);
            this.TokenAuxPropertiesTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT50>("Nonfungible.TokenAuxProperties", storageDataProvider, storageChangeDelegates);
            this.OwnedTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("Nonfungible.Owned", storageDataProvider, storageChangeDelegates);
            this.TokenChildrenTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("Nonfungible.TokenChildren", storageDataProvider, storageChangeDelegates);
            this.AccountBalanceTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Nonfungible.AccountBalance", storageDataProvider, storageChangeDelegates);
            this.AllowanceTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>("Nonfungible.Allowance", storageDataProvider, storageChangeDelegates);
            this.CollectionAllowanceTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("Nonfungible.CollectionAllowance", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _tokensMintedTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> TokensMintedTypedStorage
        {
            get
            {
                return _tokensMintedTypedStorage;
            }
            set
            {
                _tokensMintedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tokensBurntTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> TokensBurntTypedStorage
        {
            get
            {
                return _tokensBurntTypedStorage;
            }
            set
            {
                _tokensBurntTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tokenDataTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_nonfungible.ItemData> TokenDataTypedStorage
        {
            get
            {
                return _tokenDataTypedStorage;
            }
            set
            {
                _tokenDataTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tokenPropertiesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2> TokenPropertiesTypedStorage
        {
            get
            {
                return _tokenPropertiesTypedStorage;
            }
            set
            {
                _tokenPropertiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tokenAuxPropertiesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT50> TokenAuxPropertiesTypedStorage
        {
            get
            {
                return _tokenAuxPropertiesTypedStorage;
            }
            set
            {
                _tokenAuxPropertiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _ownedTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> OwnedTypedStorage
        {
            get
            {
                return _ownedTypedStorage;
            }
            set
            {
                _ownedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tokenChildrenTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> TokenChildrenTypedStorage
        {
            get
            {
                return _tokenChildrenTypedStorage;
            }
            set
            {
                _tokenChildrenTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _accountBalanceTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> AccountBalanceTypedStorage
        {
            get
            {
                return _accountBalanceTypedStorage;
            }
            set
            {
                _accountBalanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _allowanceTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> AllowanceTypedStorage
        {
            get
            {
                return _allowanceTypedStorage;
            }
            set
            {
                _allowanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _collectionAllowanceTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.Bool> CollectionAllowanceTypedStorage
        {
            get
            {
                return _collectionAllowanceTypedStorage;
            }
            set
            {
                _collectionAllowanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await TokensMintedTypedStorage.InitializeAsync("Nonfungible", "TokensMinted");
            await TokensBurntTypedStorage.InitializeAsync("Nonfungible", "TokensBurnt");
            await TokenDataTypedStorage.InitializeAsync("Nonfungible", "TokenData");
            await TokenPropertiesTypedStorage.InitializeAsync("Nonfungible", "TokenProperties");
            await TokenAuxPropertiesTypedStorage.InitializeAsync("Nonfungible", "TokenAuxProperties");
            await OwnedTypedStorage.InitializeAsync("Nonfungible", "Owned");
            await TokenChildrenTypedStorage.InitializeAsync("Nonfungible", "TokenChildren");
            await AccountBalanceTypedStorage.InitializeAsync("Nonfungible", "AccountBalance");
            await AllowanceTypedStorage.InitializeAsync("Nonfungible", "Allowance");
            await CollectionAllowanceTypedStorage.InitializeAsync("Nonfungible", "CollectionAllowance");
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.TokensMinted
        /// </summary>
        [StorageChange("Nonfungible", "TokensMinted")]
        public void OnUpdateTokensMinted(string key, string data)
        {
            TokensMintedTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokensMinted
        ///  Total amount of minted tokens in a collection.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetTokensMinted(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokensMintedTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.TokensBurnt
        /// </summary>
        [StorageChange("Nonfungible", "TokensBurnt")]
        public void OnUpdateTokensBurnt(string key, string data)
        {
            TokensBurntTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokensBurnt
        ///  Amount of burnt tokens in a collection.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetTokensBurnt(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokensBurntTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.TokenData
        /// </summary>
        [StorageChange("Nonfungible", "TokenData")]
        public void OnUpdateTokenData(string key, string data)
        {
            TokenDataTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokenData
        ///  Token data, used to partially describe a token.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_nonfungible.ItemData GetTokenData(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokenDataTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_nonfungible.ItemData result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.TokenProperties
        /// </summary>
        [StorageChange("Nonfungible", "TokenProperties")]
        public void OnUpdateTokenProperties(string key, string data)
        {
            TokenPropertiesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokenProperties
        ///  Map of key-value pairs, describing the metadata of a token.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2 GetTokenProperties(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokenPropertiesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs.PropertiesT2 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.TokenAuxProperties
        /// </summary>
        [StorageChange("Nonfungible", "TokenAuxProperties")]
        public void OnUpdateTokenAuxProperties(string key, string data)
        {
            TokenAuxPropertiesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokenAuxProperties
        ///  Custom data of a token that is serialized to bytes,
        ///  primarily reserved for on-chain operations,
        ///  normally obscured from the external users.
        /// 
        ///  Auxiliary properties are slightly different from
        ///  usual [`TokenProperties`] due to an unlimited number
        ///  and separately stored and written-to key-value pairs.
        /// 
        ///  Currently unused.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT50 GetTokenAuxProperties(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokenAuxPropertiesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT50 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.Owned
        /// </summary>
        [StorageChange("Nonfungible", "Owned")]
        public void OnUpdateOwned(string key, string data)
        {
            OwnedTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Owned
        ///  Used to enumerate tokens owned by account.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetOwned(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OwnedTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.Bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.TokenChildren
        /// </summary>
        [StorageChange("Nonfungible", "TokenChildren")]
        public void OnUpdateTokenChildren(string key, string data)
        {
            TokenChildrenTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokenChildren
        ///  Used to enumerate token's children.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetTokenChildren(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokenChildrenTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.Bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.AccountBalance
        /// </summary>
        [StorageChange("Nonfungible", "AccountBalance")]
        public void OnUpdateAccountBalance(string key, string data)
        {
            AccountBalanceTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AccountBalance
        ///  Amount of tokens owned by an account in a collection.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetAccountBalance(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountBalanceTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.Allowance
        /// </summary>
        [StorageChange("Nonfungible", "Allowance")]
        public void OnUpdateAllowance(string key, string data)
        {
            AllowanceTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Allowance
        ///  Allowance set by a token owner for another user to perform one of certain transactions on a token.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr GetAllowance(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AllowanceTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Nonfungible.CollectionAllowance
        /// </summary>
        [StorageChange("Nonfungible", "CollectionAllowance")]
        public void OnUpdateCollectionAllowance(string key, string data)
        {
            CollectionAllowanceTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CollectionAllowance
        ///  Operator set by a wallet owner that could perform certain transactions on all tokens in the wallet.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetCollectionAllowance(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CollectionAllowanceTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.Bool result))
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
