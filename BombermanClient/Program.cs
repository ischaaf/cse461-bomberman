﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BombermanGame game = new BombermanGame();
            game.Run();
        }
    }
}
