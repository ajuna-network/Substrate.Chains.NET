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


namespace Substrate.Hydration.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IIdentityStorage interface definition.
    /// </summary>
    public interface IIdentityStorage : IStorage
    {
        
        /// <summary>
        /// >> IdentityOf
        ///  Information that is pertinent to identify the entity behind an account. First item is the
        ///  registration, second is the account's primary username.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>> GetIdentityOf(string key);
        
        /// <summary>
        /// >> SuperOf
        ///  The super-identity of an alternative "sub" identity together with its name, within that
        ///  context. If the account is not some other account's sub-identity, then just `None`.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData> GetSuperOf(string key);
        
        /// <summary>
        /// >> SubsOf
        ///  Alternative "sub" identities of this account.
        /// 
        ///  The first item is the deposit, the second is a vector of the accounts.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT30> GetSubsOf(string key);
        
        /// <summary>
        /// >> Registrars
        ///  The set of registrars. Not expected to get very big as can only be added through a
        ///  special origin (likely a council motion).
        /// 
        ///  The index into this can be cast to `RegistrarIndex` to get a valid value.
        /// </summary>
        Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT31 GetRegistrars();
        
        /// <summary>
        /// >> UsernameAuthorities
        ///  A map of the accounts who are authorized to grant usernames.
        /// </summary>
        Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.AuthorityProperties GetUsernameAuthorities(string key);
        
        /// <summary>
        /// >> AccountOfUsername
        ///  Reverse lookup from `username` to the `AccountId` that has registered it. The value should
        ///  be a key in the `IdentityOf` map, but it may not if the user has cleared their identity.
        /// 
        ///  Multiple usernames may map to the same `AccountId`, but `IdentityOf` will only map to one
        ///  primary username.
        /// </summary>
        Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetAccountOfUsername(string key);
        
        /// <summary>
        /// >> PendingUsernames
        ///  Usernames that an authority has granted, but that the account controller has not confirmed
        ///  that they want it. Used primarily in cases where the `AccountId` cannot provide a signature
        ///  because they are a pure proxy, multisig, etc. In order to confirm it, they should call
        ///  [`Call::accept_username`].
        /// 
        ///  First tuple item is the account and second is the acceptance deadline.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> GetPendingUsernames(string key);
    }
    
    /// <summary>
    /// IdentityStorage class definition.
    /// </summary>
    public sealed class IdentityStorage : IIdentityStorage
    {
        
        /// <summary>
        /// _identityOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>>> _identityOfTypedStorage;
        
        /// <summary>
        /// _superOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>> _superOfTypedStorage;
        
        /// <summary>
        /// _subsOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT30>> _subsOfTypedStorage;
        
        /// <summary>
        /// _registrarsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT31> _registrarsTypedStorage;
        
        /// <summary>
        /// _usernameAuthoritiesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.AuthorityProperties> _usernameAuthoritiesTypedStorage;
        
        /// <summary>
        /// _accountOfUsernameTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _accountOfUsernameTypedStorage;
        
        /// <summary>
        /// _pendingUsernamesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>> _pendingUsernamesTypedStorage;
        
        /// <summary>
        /// IdentityStorage constructor.
        /// </summary>
        public IdentityStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.IdentityOfTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>>>("Identity.IdentityOf", storageDataProvider, storageChangeDelegates);
            this.SuperOfTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>>("Identity.SuperOf", storageDataProvider, storageChangeDelegates);
            this.SubsOfTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT30>>("Identity.SubsOf", storageDataProvider, storageChangeDelegates);
            this.RegistrarsTypedStorage = new TypedStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT31>("Identity.Registrars", storageDataProvider, storageChangeDelegates);
            this.UsernameAuthoritiesTypedStorage = new TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.AuthorityProperties>("Identity.UsernameAuthorities", storageDataProvider, storageChangeDelegates);
            this.AccountOfUsernameTypedStorage = new TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>("Identity.AccountOfUsername", storageDataProvider, storageChangeDelegates);
            this.PendingUsernamesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>>("Identity.PendingUsernames", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _identityOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>>> IdentityOfTypedStorage
        {
            get
            {
                return _identityOfTypedStorage;
            }
            set
            {
                _identityOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _superOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>> SuperOfTypedStorage
        {
            get
            {
                return _superOfTypedStorage;
            }
            set
            {
                _superOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _subsOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT30>> SubsOfTypedStorage
        {
            get
            {
                return _subsOfTypedStorage;
            }
            set
            {
                _subsOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _registrarsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT31> RegistrarsTypedStorage
        {
            get
            {
                return _registrarsTypedStorage;
            }
            set
            {
                _registrarsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _usernameAuthoritiesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.AuthorityProperties> UsernameAuthoritiesTypedStorage
        {
            get
            {
                return _usernameAuthoritiesTypedStorage;
            }
            set
            {
                _usernameAuthoritiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _accountOfUsernameTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> AccountOfUsernameTypedStorage
        {
            get
            {
                return _accountOfUsernameTypedStorage;
            }
            set
            {
                _accountOfUsernameTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _pendingUsernamesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>> PendingUsernamesTypedStorage
        {
            get
            {
                return _pendingUsernamesTypedStorage;
            }
            set
            {
                _pendingUsernamesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await IdentityOfTypedStorage.InitializeAsync("Identity", "IdentityOf");
            await SuperOfTypedStorage.InitializeAsync("Identity", "SuperOf");
            await SubsOfTypedStorage.InitializeAsync("Identity", "SubsOf");
            await RegistrarsTypedStorage.InitializeAsync("Identity", "Registrars");
            await UsernameAuthoritiesTypedStorage.InitializeAsync("Identity", "UsernameAuthorities");
            await AccountOfUsernameTypedStorage.InitializeAsync("Identity", "AccountOfUsername");
            await PendingUsernamesTypedStorage.InitializeAsync("Identity", "PendingUsernames");
        }
        
        /// <summary>
        /// Implements any storage change for Identity.IdentityOf
        /// </summary>
        [StorageChange("Identity", "IdentityOf")]
        public void OnUpdateIdentityOf(string key, string data)
        {
            IdentityOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> IdentityOf
        ///  Information that is pertinent to identify the entity behind an account. First item is the
        ///  registration, second is the account's primary username.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>> GetIdentityOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (IdentityOfTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Identity.SuperOf
        /// </summary>
        [StorageChange("Identity", "SuperOf")]
        public void OnUpdateSuperOf(string key, string data)
        {
            SuperOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> SuperOf
        ///  The super-identity of an alternative "sub" identity together with its name, within that
        ///  context. If the account is not some other account's sub-identity, then just `None`.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData> GetSuperOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SuperOfTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Identity.SubsOf
        /// </summary>
        [StorageChange("Identity", "SubsOf")]
        public void OnUpdateSubsOf(string key, string data)
        {
            SubsOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> SubsOf
        ///  Alternative "sub" identities of this account.
        /// 
        ///  The first item is the deposit, the second is a vector of the accounts.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT30> GetSubsOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SubsOfTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT30> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Identity.Registrars
        /// </summary>
        [StorageChange("Identity", "Registrars")]
        public void OnUpdateRegistrars(string data)
        {
            RegistrarsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Registrars
        ///  The set of registrars. Not expected to get very big as can only be added through a
        ///  special origin (likely a council motion).
        /// 
        ///  The index into this can be cast to `RegistrarIndex` to get a valid value.
        /// </summary>
        public Substrate.Hydration.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT31 GetRegistrars()
        {
            return RegistrarsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Identity.UsernameAuthorities
        /// </summary>
        [StorageChange("Identity", "UsernameAuthorities")]
        public void OnUpdateUsernameAuthorities(string key, string data)
        {
            UsernameAuthoritiesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> UsernameAuthorities
        ///  A map of the accounts who are authorized to grant usernames.
        /// </summary>
        public Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.AuthorityProperties GetUsernameAuthorities(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (UsernameAuthoritiesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_identity.types.AuthorityProperties result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Identity.AccountOfUsername
        /// </summary>
        [StorageChange("Identity", "AccountOfUsername")]
        public void OnUpdateAccountOfUsername(string key, string data)
        {
            AccountOfUsernameTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AccountOfUsername
        ///  Reverse lookup from `username` to the `AccountId` that has registered it. The value should
        ///  be a key in the `IdentityOf` map, but it may not if the user has cleared their identity.
        /// 
        ///  Multiple usernames may map to the same `AccountId`, but `IdentityOf` will only map to one
        ///  primary username.
        /// </summary>
        public Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetAccountOfUsername(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountOfUsernameTypedStorage.Dictionary.TryGetValue(key, out Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Identity.PendingUsernames
        /// </summary>
        [StorageChange("Identity", "PendingUsernames")]
        public void OnUpdatePendingUsernames(string key, string data)
        {
            PendingUsernamesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> PendingUsernames
        ///  Usernames that an authority has granted, but that the account controller has not confirmed
        ///  that they want it. Used primarily in cases where the `AccountId` cannot provide a signature
        ///  because they are a pure proxy, multisig, etc. In order to confirm it, they should call
        ///  [`Call::accept_username`].
        /// 
        ///  First tuple item is the account and second is the acceptance deadline.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> GetPendingUsernames(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PendingUsernamesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Hydration.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32> result))
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
