using System;

namespace DelegatesAndEvents_3
{
    class Program
    {
        static void Main()
        {
            MathServices service = new MathServices();
            service.MathPerformed += OnOutboundEvent;
            //service.AddNum(4,5);
            //service.MultiplyNum(4,5);
            service.Operation(4,5);

        }

        //matches signature of OnOutboundEvent matches signature of an event handler.
        static void OnOutboundEvent(object sender,MathPerformedEventArgs args) 
        {
            Console.WriteLine($"Outbound Result: {args.MathResult} ");
        }
    }
}
