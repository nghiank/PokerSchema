// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace schema
{

using global::System;
using global::FlatBuffers;

public struct Message : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Message GetRootAsMessage(ByteBuffer _bb) { return GetRootAsMessage(_bb, new Message()); }
  public static Message GetRootAsMessage(ByteBuffer _bb, Message obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Message __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Data DataType { get { int o = __p.__offset(4); return o != 0 ? (Data)__p.bb.Get(o + __p.bb_pos) : Data.NONE; } }
  public TTable? Data<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o) : null; }

  public static Offset<Message> CreateMessage(FlatBufferBuilder builder,
      Data data_type = Data.NONE,
      int dataOffset = 0) {
    builder.StartObject(2);
    Message.AddData(builder, dataOffset);
    Message.AddDataType(builder, data_type);
    return Message.EndMessage(builder);
  }

  public static void StartMessage(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddDataType(FlatBufferBuilder builder, Data dataType) { builder.AddByte(0, (byte)dataType, 0); }
  public static void AddData(FlatBufferBuilder builder, int dataOffset) { builder.AddOffset(1, dataOffset, 0); }
  public static Offset<Message> EndMessage(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Message>(o);
  }
  public static void FinishMessageBuffer(FlatBufferBuilder builder, Offset<Message> offset) { builder.Finish(offset.Value); }
};


}
