using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public class ExecutiveDesk : AbstractDesk
    {
        public override decimal Price { get; } = 1515.00m;
        public override string ModelNumber { get; } = "ED43500";
        //public FrameType MaterialType { get; }
        public string Serial { get; private set; }
        public override decimal AccessoryPrice { get; } = 75.0m;
        public override string AccessoryDescripton { get; } = "2 Built In USB Ports and Power Strip";
        public override string DeskDescription { get; } = "Executive Desk";
        public ExecutiveDesk(FrameType frame, DeskShape shape, SurfaceTop top, bool accessory)
            : base(frame, shape, top, accessory)
        {
            Console.WriteLine();
        }
        public ExecutiveDesk(bool accessory)
            : this(FrameType.composite, DeskShape.Rectangle, SurfaceTop.composite, accessory) 
        {
            
        }
        
        
            //Console.WriteLine(".");
            //Console.WriteLine("composite.");
            //Console.WriteLine(" rectangle shape.");
        

        //public ExecutiveDesk()
        //{
            //Serial = CPUGenerator.Instance.NextCPU(DeskType.Executive);
        //}

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has 6 compartments and 6 drawers");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        
        
    } // end class
} // end namespace
