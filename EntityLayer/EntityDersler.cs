﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDersler
    {
        private string dersAd;
        public string DERSAD
        {
            get { return dersAd; }
            set { dersAd = value; }
        }

        private int min;
        public int MİN
        {
            get { return min; }
            set { min = value; }
        }

        private int max;
        public int MAX
        {
            get { return max; }
            set { max = value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
