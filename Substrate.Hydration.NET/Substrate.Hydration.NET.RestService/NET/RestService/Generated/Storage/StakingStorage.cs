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
    /// IStakingStorage interface definition.
    /// </summary>
    public interface IStakingStorage : IStorage
    {
        
        /// <summary>
        /// >> Staking
        ///  Global staking state.
        /// </summary>
        Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.StakingData GetStaking();
        
        /// <summary>
        /// >> Positions
        ///  User's position state.
        /// </summary>
        Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Position GetPositions(string key);
        
        /// <summary>
        /// >> NextPositionId
        ///  Position ids sequencer.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetNextPositionId();
        
        /// <summary>
        /// >> Votes
        ///  List of position votes.
        /// </summary>
        Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting GetVotes(string key);
        
        /// <summary>
        /// >> VotesRewarded
        ///  List of processed vote. Used to determine if the vote should be locked in case of voting not in favor.
        /// </summary>
        Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote GetVotesRewarded(string key);
        
        /// <summary>
        /// >> PositionVotes
        ///  Legacy storage! - Used to handle democracy votes until democracy pallet is fully removed.
        /// </summary>
        Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting GetPositionVotes(string key);
        
        /// <summary>
        /// >> ProcessedVotes
        ///  Legacy storage! - Used to handle democracy processed votes until democracy pallet is fully removed.
        /// </summary>
        Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote GetProcessedVotes(string key);
        
        /// <summary>
        /// >> SixSecBlocksSince
        ///  Block number when we switched to 6 sec. blocks.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetSixSecBlocksSince();
    }
    
    /// <summary>
    /// StakingStorage class definition.
    /// </summary>
    public sealed class StakingStorage : IStakingStorage
    {
        
        /// <summary>
        /// _stakingTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.StakingData> _stakingTypedStorage;
        
        /// <summary>
        /// _positionsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Position> _positionsTypedStorage;
        
        /// <summary>
        /// _nextPositionIdTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _nextPositionIdTypedStorage;
        
        /// <summary>
        /// _votesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting> _votesTypedStorage;
        
        /// <summary>
        /// _votesRewardedTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote> _votesRewardedTypedStorage;
        
        /// <summary>
        /// _positionVotesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting> _positionVotesTypedStorage;
        
        /// <summary>
        /// _processedVotesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote> _processedVotesTypedStorage;
        
        /// <summary>
        /// _sixSecBlocksSinceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _sixSecBlocksSinceTypedStorage;
        
        /// <summary>
        /// StakingStorage constructor.
        /// </summary>
        public StakingStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.StakingTypedStorage = new TypedStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.StakingData>("Staking.Staking", storageDataProvider, storageChangeDelegates);
            this.PositionsTypedStorage = new TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Position>("Staking.Positions", storageDataProvider, storageChangeDelegates);
            this.NextPositionIdTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("Staking.NextPositionId", storageDataProvider, storageChangeDelegates);
            this.VotesTypedStorage = new TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting>("Staking.Votes", storageDataProvider, storageChangeDelegates);
            this.VotesRewardedTypedStorage = new TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote>("Staking.VotesRewarded", storageDataProvider, storageChangeDelegates);
            this.PositionVotesTypedStorage = new TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting>("Staking.PositionVotes", storageDataProvider, storageChangeDelegates);
            this.ProcessedVotesTypedStorage = new TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote>("Staking.ProcessedVotes", storageDataProvider, storageChangeDelegates);
            this.SixSecBlocksSinceTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Staking.SixSecBlocksSince", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _stakingTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.StakingData> StakingTypedStorage
        {
            get
            {
                return _stakingTypedStorage;
            }
            set
            {
                _stakingTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _positionsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Position> PositionsTypedStorage
        {
            get
            {
                return _positionsTypedStorage;
            }
            set
            {
                _positionsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextPositionIdTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> NextPositionIdTypedStorage
        {
            get
            {
                return _nextPositionIdTypedStorage;
            }
            set
            {
                _nextPositionIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _votesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting> VotesTypedStorage
        {
            get
            {
                return _votesTypedStorage;
            }
            set
            {
                _votesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _votesRewardedTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote> VotesRewardedTypedStorage
        {
            get
            {
                return _votesRewardedTypedStorage;
            }
            set
            {
                _votesRewardedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _positionVotesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting> PositionVotesTypedStorage
        {
            get
            {
                return _positionVotesTypedStorage;
            }
            set
            {
                _positionVotesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _processedVotesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote> ProcessedVotesTypedStorage
        {
            get
            {
                return _processedVotesTypedStorage;
            }
            set
            {
                _processedVotesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _sixSecBlocksSinceTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> SixSecBlocksSinceTypedStorage
        {
            get
            {
                return _sixSecBlocksSinceTypedStorage;
            }
            set
            {
                _sixSecBlocksSinceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await StakingTypedStorage.InitializeAsync("Staking", "Staking");
            await PositionsTypedStorage.InitializeAsync("Staking", "Positions");
            await NextPositionIdTypedStorage.InitializeAsync("Staking", "NextPositionId");
            await VotesTypedStorage.InitializeAsync("Staking", "Votes");
            await VotesRewardedTypedStorage.InitializeAsync("Staking", "VotesRewarded");
            await PositionVotesTypedStorage.InitializeAsync("Staking", "PositionVotes");
            await ProcessedVotesTypedStorage.InitializeAsync("Staking", "ProcessedVotes");
            await SixSecBlocksSinceTypedStorage.InitializeAsync("Staking", "SixSecBlocksSince");
        }
        
        /// <summary>
        /// Implements any storage change for Staking.Staking
        /// </summary>
        [StorageChange("Staking", "Staking")]
        public void OnUpdateStaking(string data)
        {
            StakingTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Staking
        ///  Global staking state.
        /// </summary>
        public Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.StakingData GetStaking()
        {
            return StakingTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Staking.Positions
        /// </summary>
        [StorageChange("Staking", "Positions")]
        public void OnUpdatePositions(string key, string data)
        {
            PositionsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Positions
        ///  User's position state.
        /// </summary>
        public Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Position GetPositions(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PositionsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Position result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Staking.NextPositionId
        /// </summary>
        [StorageChange("Staking", "NextPositionId")]
        public void OnUpdateNextPositionId(string data)
        {
            NextPositionIdTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextPositionId
        ///  Position ids sequencer.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetNextPositionId()
        {
            return NextPositionIdTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Staking.Votes
        /// </summary>
        [StorageChange("Staking", "Votes")]
        public void OnUpdateVotes(string key, string data)
        {
            VotesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Votes
        ///  List of position votes.
        /// </summary>
        public Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting GetVotes(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VotesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Staking.VotesRewarded
        /// </summary>
        [StorageChange("Staking", "VotesRewarded")]
        public void OnUpdateVotesRewarded(string key, string data)
        {
            VotesRewardedTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VotesRewarded
        ///  List of processed vote. Used to determine if the vote should be locked in case of voting not in favor.
        /// </summary>
        public Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote GetVotesRewarded(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VotesRewardedTypedStorage.Dictionary.TryGetValue(key, out Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Staking.PositionVotes
        /// </summary>
        [StorageChange("Staking", "PositionVotes")]
        public void OnUpdatePositionVotes(string key, string data)
        {
            PositionVotesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> PositionVotes
        ///  Legacy storage! - Used to handle democracy votes until democracy pallet is fully removed.
        /// </summary>
        public Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting GetPositionVotes(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PositionVotesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Voting result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Staking.ProcessedVotes
        /// </summary>
        [StorageChange("Staking", "ProcessedVotes")]
        public void OnUpdateProcessedVotes(string key, string data)
        {
            ProcessedVotesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ProcessedVotes
        ///  Legacy storage! - Used to handle democracy processed votes until democracy pallet is fully removed.
        /// </summary>
        public Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote GetProcessedVotes(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ProcessedVotesTypedStorage.Dictionary.TryGetValue(key, out Substrate.Hydration.NET.NetApiExt.Generated.Model.pallet_staking.types.Vote result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Staking.SixSecBlocksSince
        /// </summary>
        [StorageChange("Staking", "SixSecBlocksSince")]
        public void OnUpdateSixSecBlocksSince(string data)
        {
            SixSecBlocksSinceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> SixSecBlocksSince
        ///  Block number when we switched to 6 sec. blocks.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetSixSecBlocksSince()
        {
            return SixSecBlocksSinceTypedStorage.Get();
        }
    }
}
