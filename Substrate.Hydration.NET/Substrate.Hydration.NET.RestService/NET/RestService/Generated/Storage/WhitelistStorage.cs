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
    /// IWhitelistStorage interface definition.
    /// </summary>
    public interface IWhitelistStorage : IStorage
    {
        
        /// <summary>
        /// >> WhitelistedCall
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple GetWhitelistedCall(string key);
    }
    
    /// <summary>
    /// WhitelistStorage class definition.
    /// </summary>
    public sealed class WhitelistStorage : IWhitelistStorage
    {
        
        /// <summary>
        /// _whitelistedCallTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> _whitelistedCallTypedStorage;
        
        /// <summary>
        /// WhitelistStorage constructor.
        /// </summary>
        public WhitelistStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.WhitelistedCallTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple>("Whitelist.WhitelistedCall", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _whitelistedCallTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple> WhitelistedCallTypedStorage
        {
            get
            {
                return _whitelistedCallTypedStorage;
            }
            set
            {
                _whitelistedCallTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await WhitelistedCallTypedStorage.InitializeAsync("Whitelist", "WhitelistedCall");
        }
        
        /// <summary>
        /// Implements any storage change for Whitelist.WhitelistedCall
        /// </summary>
        [StorageChange("Whitelist", "WhitelistedCall")]
        public void OnUpdateWhitelistedCall(string key, string data)
        {
            WhitelistedCallTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> WhitelistedCall
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple GetWhitelistedCall(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (WhitelistedCallTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple result))
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
