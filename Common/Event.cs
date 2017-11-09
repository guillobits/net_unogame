﻿using System;
using System.Collections.Generic;
using System.IO;
using ProtoBuf;

namespace Common
{
    public enum EventType
    {
        InvalidCommand = -1,
        YourTurn = 0,
        PlayerTurn,
        PlayerHasPlayed,
        EndGame,
    }
    
    [ProtoContract]
    public class Event
    {
        public Event()
        {
            Player = null;
            Table = null;
            ErrorMsg = null;
            HasDraw = false;
            Type = EventType.InvalidCommand;
        }
        
        public Event(string errorMsg)
        {
            ErrorMsg = errorMsg;
            Type = EventType.InvalidCommand;
        }

        public Event(EventType type, Player player = null, Table table = null)
        {
            Type = type;
            Player = player;
            Table = table;
            HasDraw = false;
            ErrorMsg = null;
        }
        
        [ProtoMember(1)]
        public Player Player { get; set; }
        [ProtoMember(2)]
        public EventType Type { get; set; }
        [ProtoMember(3)]
        public string ErrorMsg { get; set; }
        [ProtoMember(4)]
        public Table Table { get; set; }
        [ProtoMember(5)]
        public bool HasDraw { get; set; }
        
    }
}