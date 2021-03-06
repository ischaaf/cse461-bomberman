﻿using BombermanObjects;
using Lidgren.Network;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanServer
{
    public class ServerGameRunner : Game
    {
        public GameManager Manager { get; set; }

        public BombermanServer Server { get; set; }

        protected GraphicsDeviceManager graphics;

        public ServerGameRunner(GameManager manager, BombermanServer server)
        {
            Manager = manager;
            Server = server;
            graphics = new GraphicsDeviceManager(this);

        }

        protected override void Initialize()
        {
            base.Initialize();


            Form MyGameForm = (Form)Form.FromHandle(Window.Handle);
            MyGameForm.Opacity = 0;
            for (int i = 0; i < Server.playerInfoArr.Length; i++)
            {
                Console.WriteLine($"Broadcasting to connected player {i + 1} that game has started");
                NetOutgoingMessage newPlayerMsg = Server.server.CreateMessage();
                newPlayerMsg.Write((byte)0);
                newPlayerMsg.Write((byte)PacketTypeEnums.PacketType.GAME_START);
                Server.server.SendMessage(newPlayerMsg, Server.playerInfoArr[i].playerConnection, NetDeliveryMethod.ReliableOrdered, 0);
            }
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (Manager.GameOver)
                Exit();
            Server.Update(gameTime);
            Manager.Update(gameTime);
            //Console.WriteLine($"Lag: {gameTime.IsRunningSlowly}");
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
