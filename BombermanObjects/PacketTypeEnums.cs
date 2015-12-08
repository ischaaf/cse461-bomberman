﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanObjects
{
    public class PacketTypeEnums
    {
        public enum PacketType : byte
        {
            EVENT,
            GAME_STATE,
            GAME_STATE_FULL, 
            SEND_PLAYER_ID,
            NEW_PLAYER_ID
            
        };

        public enum EventType : byte
        {
            EVENT_MOVE,
            EVENT_BOMB_PLACEMENT
        };
    }
}
