﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Networking.NetworkSystem.ObjectSpawnMessage
// Assembly: UnityEngine.Networking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B34E19C-EF53-416E-AE36-35C45BAFD2DE
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.Networking.dll

namespace UnityEngine.Networking.NetworkSystem
{
  internal class ObjectSpawnMessage : MessageBase
  {
    public NetworkInstanceId netId;
    public NetworkHash128 assetId;
    public Vector3 position;
    public byte[] payload;

    public override void Deserialize(NetworkReader reader)
    {
      this.netId = reader.ReadNetworkId();
      this.assetId = reader.ReadNetworkHash128();
      this.position = reader.ReadVector3();
      this.payload = reader.ReadBytesAndSize();
    }

    public override void Serialize(NetworkWriter writer)
    {
      writer.Write(this.netId);
      writer.Write(this.assetId);
      writer.Write(this.position);
      writer.WriteBytesFull(this.payload);
    }
  }
}
