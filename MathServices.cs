using System;

namespace DelegatesAndEvents_3
{
    internal class MathServices
    {
        internal event EventHandler<MathPerformedEventArgs> MathPerformed;

        internal delegate void OperationHandler(double value1,double value2);

        internal OperationHandler Operation;

        internal MathServices()
        {
            
            Operation+= AddNum;
            Operation+= MultiplyNum;

        }

        internal void AddNum(double value1, double value2)
        {
            var result = value1 + value2;
            //MathPerformed(this,new MathPerformedEventArgs(result));
            MathPerformed?.Invoke(this, new MathPerformedEventArgs(result));

        }

        internal void MultiplyNum(double value1, double value2)
        {
            var result = value1*value2;
            MathPerformed?.Invoke(this,new MathPerformedEventArgs(result));

        }
    }
}