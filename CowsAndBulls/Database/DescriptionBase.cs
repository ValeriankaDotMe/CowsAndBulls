using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls.Database
{
    static class DescriptionBase
    {
        private static string normalDescription;
        private static string hardDescription;

        public static string NormalDescription
        {
            get;
            set;
        }

        public static string HardDescription
        {
            get;
            set;
        }

        public static void Read()
        {
            try
            {
                string normal = System.IO.File.ReadAllText("normal.txt");
                string hard = System.IO.File.ReadAllText("hard.txt");

                NormalDescription = normal;
                HardDescription = hard;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
