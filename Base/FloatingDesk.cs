using System;
using System.Collections.Generic;
using System.Text;
using DeskFinalProject.Singleton;

namespace DeskFinalProject.Base
{
    public class FloatingDesk : AbstractDesk
    {
        private DeskShape rectangle;
        private SurfaceTop composite;
        private FrameType compostie;
        internal static FrameType WireManagementContainer;

        public override decimal Price { get; } = 75.00m;
        public FrameType MaterialType { get ;  }
        public DeskShape GetShape { get; }
        public override string ModelNumber { get; } = "DF1029";
        public override decimal AccessoryPrice { get;  } = 50.0m;
        public override string AccessoryDescripton { get; } = "Wire Management Container";
        public override string DeskDescription { get; } = "Floating Desk";
        public FloatingDesk(FrameType frame, DeskShape shape, SurfaceTop top, bool accessory)
            : base(frame, shape, top, accessory)
        {

        }

        public FloatingDesk(bool accessory)
            : this(FrameType.composite, DeskShape.Rectangle, SurfaceTop.composite, accessory)
        {
            
        }

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has 3 compartments and 2 shelves");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        
       
        
    } // end class 
} // end namespace

