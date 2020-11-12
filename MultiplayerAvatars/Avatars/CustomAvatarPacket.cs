﻿using LiteNetLib.Utils;
using MultiplayerExtensions.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplayerAvatars.Avatars
{
    public class CustomAvatarPacket : CustomPacket<CustomAvatarPacket>
    {
        public override void Serialize(NetDataWriter writer)
        {
            writer.Put(hash);
            writer.Put(scale);
            writer.Put(floor);
        }

        public override void Deserialize(NetDataReader reader)
        {
            hash = reader.GetString();
            scale = reader.GetFloat();
            floor = reader.GetFloat();
        }

        public CustomAvatarPacket Init(string avatarHash, float avatarScale, float avatarFloor)
        {
            this.hash = avatarHash;
            this.scale = avatarScale;
            this.floor = avatarFloor;

            return this;
        }

        public string hash;
        public float scale;
        public float floor;
    }
}