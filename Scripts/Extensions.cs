﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mumble
{
    public static class MumbleExtensions
    {
        public static IntPtr Add(this IntPtr oldPtr, int offset)
        {
            return new IntPtr(oldPtr.ToInt64() + offset);
        }
    }
}
