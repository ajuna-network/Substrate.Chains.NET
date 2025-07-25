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
    /// IFinancialCouncilMembershipStorage interface definition.
    /// </summary>
    public interface IFinancialCouncilMembershipStorage : IStorage
    {
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43 GetMembers();
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetPrime();
    }
    
    /// <summary>
    /// FinancialCouncilMembershipStorage class definition.
    /// </summary>
    public sealed class FinancialCouncilMembershipStorage : IFinancialCouncilMembershipStorage
    {
        
        /// <summary>
        /// _membersTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43> _membersTypedStorage;
        
        /// <summary>
        /// _primeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _primeTypedStorage;
        
        /// <summary>
        /// FinancialCouncilMembershipStorage constructor.
        /// </summary>
        public FinancialCouncilMembershipStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.MembersTypedStorage = new TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43>("FinancialCouncilMembership.Members", storageDataProvider, storageChangeDelegates);
            this.PrimeTypedStorage = new TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>("FinancialCouncilMembership.Prime", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _membersTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43> MembersTypedStorage
        {
            get
            {
                return _membersTypedStorage;
            }
            set
            {
                _membersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _primeTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> PrimeTypedStorage
        {
            get
            {
                return _primeTypedStorage;
            }
            set
            {
                _primeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await MembersTypedStorage.InitializeAsync("FinancialCouncilMembership", "Members");
            await PrimeTypedStorage.InitializeAsync("FinancialCouncilMembership", "Prime");
        }
        
        /// <summary>
        /// Implements any storage change for FinancialCouncilMembership.Members
        /// </summary>
        [StorageChange("FinancialCouncilMembership", "Members")]
        public void OnUpdateMembers(string data)
        {
            MembersTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT43 GetMembers()
        {
            return MembersTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FinancialCouncilMembership.Prime
        /// </summary>
        [StorageChange("FinancialCouncilMembership", "Prime")]
        public void OnUpdatePrime(string data)
        {
            PrimeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetPrime()
        {
            return PrimeTypedStorage.Get();
        }
    }
}
