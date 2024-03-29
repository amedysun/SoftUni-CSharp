﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public string RandomString()
        {
            if (this.Count == 0)
            {
                return null;
            }
            return this[random.Next(0,this.Count)];
        }
    }
}
