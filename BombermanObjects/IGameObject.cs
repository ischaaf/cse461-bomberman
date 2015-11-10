﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanObjects
{
    public interface IGameObject : INotifyPropertyChanged
    {
        Rectangle Position { get; set; }

        
    }
}
