//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.Unique.NET.NetApiExt.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 359 - Composite[up_data_structs.CreateReFungibleData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CreateReFungibleData : BaseType
    {
        
        /// <summary>
        /// >> pieces
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Pieces { get; set; }
        /// <summary>
        /// >> properties
        /// </summary>
        public Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18 Properties { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CreateReFungibleData";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Pieces.Encode());
            result.AddRange(Properties.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Pieces = new Substrate.NetApi.Model.Types.Primitive.U128();
            Pieces.Decode(byteArray, ref p);
            Properties = new Substrate.Unique.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18();
            Properties.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
