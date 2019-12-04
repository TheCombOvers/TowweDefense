﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TowerDefenseGUI
{
    public class Map
    {
        public enum Direction { RIGHT, LEFT, UP, DOWN };
        static List<Image> maps = new List<Image>();
        static List<List<Intersection>> pathways = new List<List<Intersection>>();
        public static Image map;
        public static List<Intersection> coords;
        public int mapID;

        // map 1 coords ( [0,350], [350,350], [350,150], [750,150], [750,600], [200,600], [200,800], [500,800], [500,900] )
        public Map(int id)
        {
            var path = new List<Intersection>();
            path.Add(new Intersection(0, 350, Direction.RIGHT)); // 0,350
            path.Add(new Intersection(350, 350, Direction.RIGHT)); // 350, 350
            path.Add(new Intersection(350, 150, Direction.UP)); // 350, 150
            path.Add(new Intersection(750, 150, Direction.RIGHT)); // 750, 150
            path.Add(new Intersection(750, 600, Direction.DOWN)); // 750, 600
            path.Add(new Intersection(200, 600, Direction.LEFT)); // 200, 600
            path.Add(new Intersection(200, 800, Direction.DOWN)); // 200, 800
            path.Add(new Intersection(500, 800, Direction.RIGHT)); // 500, 800
            path.Add(new Intersection(500, 900, Direction.DOWN)); // 500, 900
            pathways.Add(path);
            mapID = id;
            coords = pathways[mapID];
        }
    }

    public struct Intersection
    {
        public int x;
        public int y;
        public Map.Direction direction;

        public Intersection(int v1, int v2, Map.Direction dir)
        {
            x = v1;
            y = v2;
            direction = dir;
        }
    }
}
