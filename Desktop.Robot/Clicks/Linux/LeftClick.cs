﻿using System;
namespace Desktop.Robot.Clicks.Linux
{
    internal class LeftClick : IClick
    {
        private readonly int delay;
        public LeftClick(int delay)
        {
            this.delay = delay;
        }
        public void ExecuteClick(MouseContext context)
        {
            throw new NotImplementedException();
        }
    }
}
