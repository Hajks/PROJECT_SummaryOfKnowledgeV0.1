﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_SummaryOfKnowledgeV0._1
{
    class Player : Mover
    {
        private Weapon equippedWeapon;

        public int HitPoints { get; private set; }

        private List<Weapon> inventory = new List <Weapon>();


    }
}
