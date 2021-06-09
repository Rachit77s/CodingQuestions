﻿using BowlingWithFrame.AbstractClass;
using System.Collections;

namespace BowlingWithFrame.Helpers
{
    public class BonusRoll : Frame
    {
        public BonusRoll(ArrayList throws, int firstThrow) : base(throws)
        {
            throws.Add(firstThrow);
        }

        override public int Score()
        {
            return 0;
        }

        override protected int FrameSize()
        {
            return 0;
        }
    }
}
