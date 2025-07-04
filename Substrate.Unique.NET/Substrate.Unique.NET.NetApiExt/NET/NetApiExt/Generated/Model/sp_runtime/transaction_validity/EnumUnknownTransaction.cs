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


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.sp_runtime.transaction_validity
{
    
    
    /// <summary>
    /// >> UnknownTransaction
    /// </summary>
    public enum UnknownTransaction
    {
        
        /// <summary>
        /// >> CannotLookup
        /// </summary>
        CannotLookup = 0,
        
        /// <summary>
        /// >> NoUnsignedValidator
        /// </summary>
        NoUnsignedValidator = 1,
        
        /// <summary>
        /// >> Custom
        /// </summary>
        Custom = 2,
    }
    
    /// <summary>
    /// >> 681 - Variant[sp_runtime.transaction_validity.UnknownTransaction]
    /// </summary>
    public sealed class EnumUnknownTransaction : BaseEnumRust<UnknownTransaction>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumUnknownTransaction()
        {
				AddTypeDecoder<BaseVoid>(UnknownTransaction.CannotLookup);
				AddTypeDecoder<BaseVoid>(UnknownTransaction.NoUnsignedValidator);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U8>(UnknownTransaction.Custom);
        }
    }
}
