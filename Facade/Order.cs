using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Facade
{
    public class Order 
    {
        private IDesk _desk;
        public Order (IDesk desk)
        {
            this._desk = desk;
        }

        //public void TrackingUpcNumber()
        //{
            //Console.WriteLine("Tracking the UPC Number");
        //}
    } // end class
} // end namespace

