﻿using System.Runtime.InteropServices;

namespace Game.Networking
{
    [StructLayout(LayoutKind.Explicit)]
    public struct LongUnion
    {
        [FieldOffset(0)]
        public long Value;
        [FieldOffset(0)]
        public byte B0;
        [FieldOffset(1)]
        public byte B1;
        [FieldOffset(2)]
        public byte B2;
        [FieldOffset(3)]
        public byte B3;
        [FieldOffset(4)]
        public byte B4;
        [FieldOffset(5)]
        public byte B5;
        [FieldOffset(6)]
        public byte B6;
        [FieldOffset(7)]
        public byte B7;
    }
}
