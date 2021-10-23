using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_04_04Building02
{
    public  class Creator
    {
        static Hashtable city = new Hashtable();

        /// <summary>
        /// Уникальный номер здания
        /// </summary>
        uint _idBuilding;

        static uint counter = 1;

        static void CreateBuild()
        {
            Building building =new Building();
            Random r = new Random();

            building.Add((uint)r.Next(18),(short)r.Next(125), (uint)r.Next(25));
            building.Print();

            city.Add(counter++, building);
            

        }
    }

    public class CreateABuilding1 : Creator
    {
       
       
       
    }

}
