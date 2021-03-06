﻿using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    struct Point
    {
        private int x;
        private int y;

        public Point(Vector2i v)
            : this(v.X, v.Y)
        {
        }
        public Point(int z)
            : this(z, z)
        {
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
