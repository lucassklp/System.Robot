﻿using System;
namespace Desktop.Robot.Clicks.Linux
{
    internal class RightClick : IClick
    {
        private readonly int delay;
        public RightClick(int delay)
        {
            this.delay = delay;
        }

        public void ExecuteClick(MouseContext context)
        {
            throw new NotImplementedException();
        }
    }
}
