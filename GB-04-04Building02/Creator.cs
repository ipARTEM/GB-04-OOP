using System;
using System.Collections;

namespace GB_04_04Building02
{
    public class Creator :Building
    {
        static Hashtable city = new Hashtable();
        static ICollection key = city.Keys;
        static int counter=1;

        private Creator()
        {

        }


        public static void CreateBuild(uint apartmentsOnTheFloor, short floor, uint entrance)
        {
            Building building = new Building();
            float basement = 2.1F;
            float attic = 4.2F;

            building.ApartmentsOnTheFloor = apartmentsOnTheFloor;
            building.Floor = floor;
            building.Etrance = entrance;
            building.Flat = apartmentsOnTheFloor * (uint)building.Floor * building.Etrance;
            building.Height = (floor * 3) + basement + attic;

            city.Add(counter++,building);
        }
        public static void CityPrint()
        {
            foreach (var i in key)
            {
                var j = (Building)city[i];

                Console.WriteLine($"Уникальный номер здания: {i}; высота: {j.Height}; этажность: {j.Floor}; количество квартир: {j.Flat}; количество подъездов: {j.Etrance};" );
            }
        } 

        public static void DeleteBuild(int number)
        {
            for (int i = 0; i < city.Keys.Count; i++)
            {
                if (i == number)
                {
                    city.Remove(i);
                    break;
                }
            }
        }
    }
}
