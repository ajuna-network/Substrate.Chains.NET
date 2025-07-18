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
    /// ITechnicalCommitteeStorage interface definition.
    /// </summary>
    public interface ITechnicalCommitteeStorage : IStorage
    {
        
        /// <summary>
        /// >> Proposals
        ///  The hashes of the active proposals.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36 GetProposals();
        
        /// <summary>
        /// >> ProposalOf
        ///  Actual proposal for a given hash, if it's current.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.unique_runtime.EnumRuntimeCall GetProposalOf(string key);
        
        /// <summary>
        /// >> CostOf
        ///  Consideration cost created for publishing and storing a proposal.
        /// 
        ///  Determined by [Config::Consideration] and may be not present for certain proposals (e.g. if
        ///  the proposal count at the time of creation was below threshold N).
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Unique.NET.NetApiExt.Generated.Model.frame_support.traits.tokens.fungible.HoldConsiderationT3> GetCostOf(string key);
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_collective.Votes GetVoting(string key);
        
        /// <summary>
        /// >> ProposalCount
        ///  Proposals so far.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetProposalCount();
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective. This is stored sorted (just by value).
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> GetMembers();
        
        /// <summary>
        /// >> Prime
        ///  The prime member that helps determine the default vote behavior in case of abstentions.
        /// </summary>
        Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetPrime();
    }
    
    /// <summary>
    /// TechnicalCommitteeStorage class definition.
    /// </summary>
    public sealed class TechnicalCommitteeStorage : ITechnicalCommitteeStorage
    {
        
        /// <summary>
        /// _proposalsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36> _proposalsTypedStorage;
        
        /// <summary>
        /// _proposalOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.unique_runtime.EnumRuntimeCall> _proposalOfTypedStorage;
        
        /// <summary>
        /// _costOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Unique.NET.NetApiExt.Generated.Model.frame_support.traits.tokens.fungible.HoldConsiderationT3>> _costOfTypedStorage;
        
        /// <summary>
        /// _votingTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_collective.Votes> _votingTypedStorage;
        
        /// <summary>
        /// _proposalCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _proposalCountTypedStorage;
        
        /// <summary>
        /// _membersTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>> _membersTypedStorage;
        
        /// <summary>
        /// _primeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _primeTypedStorage;
        
        /// <summary>
        /// TechnicalCommitteeStorage constructor.
        /// </summary>
        public TechnicalCommitteeStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ProposalsTypedStorage = new TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36>("TechnicalCommittee.Proposals", storageDataProvider, storageChangeDelegates);
            this.ProposalOfTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.unique_runtime.EnumRuntimeCall>("TechnicalCommittee.ProposalOf", storageDataProvider, storageChangeDelegates);
            this.CostOfTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Unique.NET.NetApiExt.Generated.Model.frame_support.traits.tokens.fungible.HoldConsiderationT3>>("TechnicalCommittee.CostOf", storageDataProvider, storageChangeDelegates);
            this.VotingTypedStorage = new TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_collective.Votes>("TechnicalCommittee.Voting", storageDataProvider, storageChangeDelegates);
            this.ProposalCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("TechnicalCommittee.ProposalCount", storageDataProvider, storageChangeDelegates);
            this.MembersTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>("TechnicalCommittee.Members", storageDataProvider, storageChangeDelegates);
            this.PrimeTypedStorage = new TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>("TechnicalCommittee.Prime", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _proposalsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36> ProposalsTypedStorage
        {
            get
            {
                return _proposalsTypedStorage;
            }
            set
            {
                _proposalsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _proposalOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.unique_runtime.EnumRuntimeCall> ProposalOfTypedStorage
        {
            get
            {
                return _proposalOfTypedStorage;
            }
            set
            {
                _proposalOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _costOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Unique.NET.NetApiExt.Generated.Model.frame_support.traits.tokens.fungible.HoldConsiderationT3>> CostOfTypedStorage
        {
            get
            {
                return _costOfTypedStorage;
            }
            set
            {
                _costOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _votingTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_collective.Votes> VotingTypedStorage
        {
            get
            {
                return _votingTypedStorage;
            }
            set
            {
                _votingTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _proposalCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> ProposalCountTypedStorage
        {
            get
            {
                return _proposalCountTypedStorage;
            }
            set
            {
                _proposalCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _membersTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>> MembersTypedStorage
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
            await ProposalsTypedStorage.InitializeAsync("TechnicalCommittee", "Proposals");
            await ProposalOfTypedStorage.InitializeAsync("TechnicalCommittee", "ProposalOf");
            await CostOfTypedStorage.InitializeAsync("TechnicalCommittee", "CostOf");
            await VotingTypedStorage.InitializeAsync("TechnicalCommittee", "Voting");
            await ProposalCountTypedStorage.InitializeAsync("TechnicalCommittee", "ProposalCount");
            await MembersTypedStorage.InitializeAsync("TechnicalCommittee", "Members");
            await PrimeTypedStorage.InitializeAsync("TechnicalCommittee", "Prime");
        }
        
        /// <summary>
        /// Implements any storage change for TechnicalCommittee.Proposals
        /// </summary>
        [StorageChange("TechnicalCommittee", "Proposals")]
        public void OnUpdateProposals(string data)
        {
            ProposalsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Proposals
        ///  The hashes of the active proposals.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36 GetProposals()
        {
            return ProposalsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TechnicalCommittee.ProposalOf
        /// </summary>
        [StorageChange("TechnicalCommittee", "ProposalOf")]
        public void OnUpdateProposalOf(string key, string data)
        {
            ProposalOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ProposalOf
        ///  Actual proposal for a given hash, if it's current.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.unique_runtime.EnumRuntimeCall GetProposalOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ProposalOfTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.unique_runtime.EnumRuntimeCall result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for TechnicalCommittee.CostOf
        /// </summary>
        [StorageChange("TechnicalCommittee", "CostOf")]
        public void OnUpdateCostOf(string key, string data)
        {
            CostOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CostOf
        ///  Consideration cost created for publishing and storing a proposal.
        /// 
        ///  Determined by [Config::Consideration] and may be not present for certain proposals (e.g. if
        ///  the proposal count at the time of creation was below threshold N).
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Unique.NET.NetApiExt.Generated.Model.frame_support.traits.tokens.fungible.HoldConsiderationT3> GetCostOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CostOfTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Unique.NET.NetApiExt.Generated.Model.frame_support.traits.tokens.fungible.HoldConsiderationT3> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for TechnicalCommittee.Voting
        /// </summary>
        [StorageChange("TechnicalCommittee", "Voting")]
        public void OnUpdateVoting(string key, string data)
        {
            VotingTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_collective.Votes GetVoting(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VotingTypedStorage.Dictionary.TryGetValue(key, out Substrate.Unique.NET.NetApiExt.Generated.Model.pallet_collective.Votes result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for TechnicalCommittee.ProposalCount
        /// </summary>
        [StorageChange("TechnicalCommittee", "ProposalCount")]
        public void OnUpdateProposalCount(string data)
        {
            ProposalCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Proposals so far.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetProposalCount()
        {
            return ProposalCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TechnicalCommittee.Members
        /// </summary>
        [StorageChange("TechnicalCommittee", "Members")]
        public void OnUpdateMembers(string data)
        {
            MembersTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective. This is stored sorted (just by value).
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> GetMembers()
        {
            return MembersTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TechnicalCommittee.Prime
        /// </summary>
        [StorageChange("TechnicalCommittee", "Prime")]
        public void OnUpdatePrime(string data)
        {
            PrimeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Prime
        ///  The prime member that helps determine the default vote behavior in case of abstentions.
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetPrime()
        {
            return PrimeTypedStorage.Get();
        }
    }
}
