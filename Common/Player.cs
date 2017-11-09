﻿using System;
using DotNetty.Transport.Channels;
using ProtoBuf;

namespace Common
{
    [ProtoContract]
    public class Player
    {
        public Player(IChannelHandlerContext context)
        {
            this.Id = _idGenerator;
            this.Hand = new Hand();
            this.Context = context;
            _idGenerator++;
            Console.Write("\n[{0}] Join the game\n$> ", this.Id);
        }

        /* Serialized Prop */
        [ProtoMember(1)]
        private static int _idGenerator = 0;
        [ProtoMember(2)]
        public int Id { get; set; }
        [ProtoMember(3)]
        public Hand Hand { get; set; }
        
        /* Non-Serialize Prop */
        public IChannelHandlerContext Context { get; set; }
    }
}