using DeskFinalProject.Base;
using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Facade
{
    public class Reciept 
    {
        private List<AbstractDesk> _Desks;
        private IDesk desk;
        private decimal total; 
        //public Reciept(IDesk desk)
        //{
            //this.desk = desk;
        //}
        public Reciept(List<AbstractDesk>desks)
        {
            this._Desks = desks;

            string recieptTitle = "Reciept";
            string titleFormat = string.Format("{0,9}", recieptTitle);
            Console.WriteLine(titleFormat);
            Console.WriteLine();

            Title();
        }

        private void Title()
        {
            Console.WriteLine();
            string title = "ANPCO Manufacturing Inc";
            string address = "1740 Paseo Blvd";
            string city = "Kansas City, MO";
            string titleFormat = string.Format("{0, 25}", title);
            string addressFormat = string.Format("{0, 17}", address);
            string cityFormat = string.Format("{0,17}", city);
            Console.WriteLine(titleFormat);
            Console.WriteLine(addressFormat);
            Console.WriteLine(cityFormat);
            Console.WriteLine();
            DataHeaders();
        }

        private void DataHeaders()
        {
            Console.WriteLine();
            string data = string.Format("{0,5} {1,25} {2,35} {3,30}",
            "Quantity ", "Model # ", "Desk Type ", "Price");
            Console.WriteLine(data);
            Console.WriteLine();
            AfterDataHeaders();
        }
        
        public void AfterDataHeaders()
        {
            
            decimal itemprice = 0m;
            string desc = "";
            foreach(AbstractDesk item in _Desks)
            {
                if (item.HasAccessory)
                {
                    desc = item.DeskDescription + "" + item.AccessoryPrice;
                    itemprice = item.Price + item.AccessoryPrice;
                     
                }
                else
                {
                    desc = item.DeskDescription;
                    itemprice = item.Price; 
                }
                total += itemprice;
                Console.WriteLine();
                string data = string.Format("{0,5} {1,28} {2,37} {3,30}", 1, 
                    item.ModelNumber, desc, itemprice);
                Console.WriteLine(data);
                desc = "";
                itemprice = 0m; 
                

            }
            DisplayTotal();   

            
        }

        private void DisplayTotal()
        {
            Console.WriteLine();
            string showTotal = string.Format("{0, 103}", "Order Total $"+total);
            Console.WriteLine(showTotal);
           
        }

        public static void PrintReciept(IDesk desk)
        {
            Console.WriteLine("Printing Reciept...");
        }
    } // end class
} // end class
