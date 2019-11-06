using DeskFinalProject.Base;
using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Facade
{
    public class OrderTaker
    {
        private List<AbstractDesk> deskList;
        private string _incorrectResponse = "You have entered an incorrect value, please try again";
        private string _FrameType, _DeskType, _SurfaceType;

        public void BeginOrder()
        {
            deskList = new List<AbstractDesk>();
            Console.WriteLine("Welcome to ANPCO Manufacturing Inc.");
            Console.WriteLine("We sell desks that don't exist");
            AddType();
        }

        private void AddType()
        {
            Console.WriteLine("What type of desk would you like?");
            Console.WriteLine("Floating, SitStand, Computer, RollTop, Executive");
            _DeskType = Console.ReadLine();
            Console.WriteLine("Would you like to customize it? Y for Yes, N for No");
            string val = Console.ReadLine();
            if (val == "N" || val == "n")
            {
                deskList.Add(CreateDefault(_DeskType));
                //AddFeatures();
            }

            else
            {
                IDesk desk = CreateDefault(_DeskType);
                AddCustom(desk);
            }
        } // end add type

        private void AddCustom(IDesk desk)
        {
            Console.WriteLine("Would you like to add a Wiremanagement Container?");
            Console.WriteLine("Would you like to add a Built-In Cord Holder?");
            Console.WriteLine("Would you like to add a Ergonomic Foot Rest?");
            Console.WriteLine("Would you like to add a Ergonomic Hand Rest? ");
            Console.WriteLine("Would yiu like to add a Built-In Power Strip?");
            Console.WriteLine("Would you like to add 2 Built-In USB Ports?");
            Console.WriteLine("Would you like to add a Lamp?");
            string val = Console.ReadLine();
            if (val == "N" || val == "n")
            {
                //go to reciept
            }else
            {
                AddType();
            }
                foreach (var item in deskList)
            {
                Console.WriteLine(item.ModelNumber + "" + item.Price);
            }

            
        }

        public void CreateCustom(string shape, string frame, string surface)
        {
            string desk = Enum.GetName(typeof(DeskShape), int.Parse(shape));
            string type = Enum.GetName(typeof(FrameType), int.Parse(frame));
            string top = Enum.GetName(typeof(SurfaceTop), int.Parse(surface));
            DeskShape myShape = (DeskShape)Enum.Parse(typeof(DeskShape), desk);
            FrameType myType = (FrameType)Enum.Parse(typeof(FrameType), type);
            SurfaceTop mySurface = (SurfaceTop)Enum.Parse(typeof(SurfaceTop), top);

            switch (type.ToLower())
            {
                case "f":
                case "FloatingDesk":
                    deskList.Add(new FloatingDesk(true));
                    break;
                case "s":
                case "SitStandDesk":
                    deskList.Add(new SitStandDesk(true));
                    break;
                case "c":
                case "ComputerDesk":
                    deskList.Add(new ComputerDesk(true));
                    break;
                case "r":
                case "RollTopDesk":
                    deskList.Add(new RollTopDesk(true));
                    break;
                case "e":
                case "ExecutiveDesk":
                    deskList.Add(new ExecutiveDesk(true));
                    break;
            }


        }

        public AbstractDesk CreateDefault(string type)
        {
            switch (type.ToLower())
            {
                case "f":
                case "FloatingDesk":
                    return new FloatingDesk(false);
                case "s":
                case "SitStandDesk":
                    return new SitStandDesk(false);
                case "c":
                case "ComputerDesk":
                    return new ComputerDesk(false);
                case "r":
                case "RollTopDesk":
                    return new RollTopDesk(false);
                case "e":
                case "ExecutiveDesk":
                default:
                    return new ExecutiveDesk(false);
            } // end switch
        }

    } // end class
} // end namespace
