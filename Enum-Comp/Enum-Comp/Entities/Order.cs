﻿using System;
using System.Collections.Generic;
using System.Text;
using Enum_Comp.Entities.Enums;

namespace Enum_Comp.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
