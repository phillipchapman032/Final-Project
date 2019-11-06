using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public interface IDesk
    {
        decimal Price { get; }
        FrameType MaterialType { get; }
        DeskShape GetShape { get; }
        object AddFeature { get; set; }
        object AddSurfaceTop { get; }
        object AddFrame { get; }
        object AddFeatures { get; }

        void Credenza();
        void Features();

        bool HasAccessory{get; set;}
        decimal AccessoryPrice{ get; }
        string AccessoryDescripton { get; }


    } // end class
} // end namespace
