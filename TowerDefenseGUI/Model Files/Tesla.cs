﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGUI
{
    class Tesla : Turret
    {
        public override string Serialize()
        {
            string tesla = string.Format("{0},{1},{2}", "tesla", xPos, yPos);
            return tesla;
        }
        public override object Deserialize(string info)
        {
            string[] finfo = info.Split(',');
            xPos = Convert.ToInt32(finfo[1]);
            yPos = Convert.ToInt32(finfo[2]);
            return this;
        }
        public static Tesla MakeTesla(int x, int y)
        {
            Tesla t = new Tesla();
            t.xPos = x;
            t.yPos = y;
            t.imageID = 5;
            t.cost = 175;
            t.damage = 3;
            t.range = 100;
            t.type = "tesla";
            return t;
        }
    }
}
