using System;

namespace DelegatesAndEvents_3
{
    internal class MathPerformedEventArgs : EventArgs
    {
        internal double MathResult{get;set;}

        //constructor
        public MathPerformedEventArgs(double result)
        {
            MathResult = result;
        }
    }
    
}