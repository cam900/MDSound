﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDSound.ZM_1
{
    public class ChipElement
    {
        protected Operator @operator;

        public ChipElement(Operator @operator)
        {
            this.@operator = @operator;
        }

        public virtual void Write(int adress, int data)
        { 
        }
    }
}
