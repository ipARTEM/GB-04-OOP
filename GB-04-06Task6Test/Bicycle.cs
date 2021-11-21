using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_04_06Task6Test
{
    public class Bicycle:Vehicle
    {
        /// <summary>
        /// Звонить
        /// </summary>
        public void RingBell()
        {
            Console.WriteLine("Ring!");
        }

        public override void Indicate(bool turningLeft)
        {
            base.Indicate(turningLeft);

            if (turningLeft)
                Console.WriteLine("Raising left arm");
            else
                Console.WriteLine("Raising right arm");
        }
    }
}
