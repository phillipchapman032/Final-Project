using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Singleton
{
    public class CPUGenerator
    {
        private static volatile CPUGenerator instance;
        private static object sychronizationRoot = new object();
        private string _prefix;

        public static CPUGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sychronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new CPUGenerator();
                        }
                    }

                }
                return instance;
            }
        }

        public string Prefix { get => _prefix; set => _prefix = value; }

        private CPUGenerator() { }
        public string NextCPU(DeskType type)
        {
            int value;
            switch (type)
            {
                case DeskType.Floating:
                    _prefix = "307951";
                    int _count = 5793;
                    value = ++_count;
                    return _prefix + value;

                case DeskType.SitStand:
                    _prefix = "652842";
                    _count = 7648;
                    value = ++_count;
                    return _prefix + value;

                case DeskType.Computer:
                    _prefix = "395710";
                    _count = 6322;
                    value = ++_count;
                    return _prefix + value;

                case DeskType.RollTop:
                    _prefix = "213542";
                    _count = 8439;
                    value = ++_count;
                    return _prefix + value;

                default:
                    _prefix = "858332";
                    _count = 4146;
                    value = ++_count;
                    return _prefix + value;

            }

        }

    } // end class
}// end namespace
