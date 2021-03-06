// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace schema
{

using global::System;
using global::FlatBuffers;

public struct RoomInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static RoomInfo GetRootAsRoomInfo(ByteBuffer _bb) { return GetRootAsRoomInfo(_bb, new RoomInfo()); }
  public static RoomInfo GetRootAsRoomInfo(ByteBuffer _bb, RoomInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public RoomInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public PlayerInfo? Players(int j) { int o = __p.__offset(4); return o != 0 ? (PlayerInfo?)(new PlayerInfo()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int PlayersLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<RoomInfo> CreateRoomInfo(FlatBufferBuilder builder,
      VectorOffset playersOffset = default(VectorOffset)) {
    builder.StartObject(1);
    RoomInfo.AddPlayers(builder, playersOffset);
    return RoomInfo.EndRoomInfo(builder);
  }

  public static void StartRoomInfo(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddPlayers(FlatBufferBuilder builder, VectorOffset playersOffset) { builder.AddOffset(0, playersOffset.Value, 0); }
  public static VectorOffset CreatePlayersVector(FlatBufferBuilder builder, Offset<PlayerInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartPlayersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<RoomInfo> EndRoomInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<RoomInfo>(o);
  }
};


}
