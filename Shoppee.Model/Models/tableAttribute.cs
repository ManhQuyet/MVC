﻿using System;

namespace Shoppee.Model.Models
{
    internal class tableAttribute : Attribute
    {
        private string v;

        public tableAttribute(string v)
        {
            this.v = v;
        }
    }
}