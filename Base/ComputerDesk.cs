using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public class ComputerDesk : AbstractDesk
    {
        public DeskShape UShaped { get; private set; }

        private DeskShape lampwith2USBBuiltInPorts;
        private DeskShape deskShape;

        public override decimal Price { get; } = 1515.00m;
        public override string ModelNumber { get; } = "CO9014";
        public new object Serial { get; }
        public override string DeskDescription { get; } = "Computer Desk";

        //public override decimal Price => throw new NotImplementedException();

        public override decimal AccessoryPrice { get; } = 80.0m;
        public override string AccessoryDescripton { get; } = "Lamp with 2 USB Ports";


        public ComputerDesk(FrameType frame, DeskShape shape, SurfaceTop top, bool accessory)
            :base(frame, shape, top, accessory)
        {
            
        }

        public ComputerDesk(bool accessory)
            :this(FrameType.wood,DeskShape.UShaped,SurfaceTop.wood, accessory)
        {
            //Serial = CPUGenerator.Instance.NextCPU(DeskType.Computer);
        }




    } // end class
} // end namespace
