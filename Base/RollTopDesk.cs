using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public class RollTopDesk : AbstractDesk
    {
        
        
        

        public override decimal Price { get; } = 1899.00m;
        public override string ModelNumber { get; } = "RO3340";
        public new FrameType MaterialType { get; }
        public new DeskShape GetShape { get; }
        public override decimal AccessoryPrice { get; } = 25.0m;
        public override string AccessoryDescripton { get; } = "Built In Cord Holder";
        public override string DeskDescription { get; } = "Roll Top Desk";

        public RollTopDesk(FrameType frame, DeskShape shape, SurfaceTop top, bool accessory)
           : base(frame, shape, top, accessory)
        {

        }

        public RollTopDesk(bool accessory)
            : this(FrameType.wood, DeskShape.Rectangle, SurfaceTop.wood, accessory) { }

        //public RollTopDesk()
        //{
            //Serial = CPUGenerator.Instance.NextCPU(DeskType.RollTop);
        //}

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has 6 drawers and 6 compartments");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

       

    } // end class
} // end namespace
