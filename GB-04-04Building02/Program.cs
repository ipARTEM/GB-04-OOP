using System;
using System.Collections;

namespace GB_04_04Building02
{
    public class Building
    {
        /// <summary>
        /// Уникальный номер здания
        /// </summary>
        public uint IdBuilding { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// Этажность
        /// </summary>
        public short Floor { get; set; }

        /// <summary>
        /// Количество квартир
        /// </summary>
        public uint Flat { get; set; }

        /// <summary>
        /// Количество подъездов
        /// </summary>
        public uint Etrance { get; set; }

        /// <summary>
        /// Количество квартир на этаже в подъезде
        /// </summary>
        public uint ApartmentsOnTheFloor { get; set; }

        public void Print()
        {

            Console.WriteLine($"Уникальный номер здания: {IdBuilding}; высота: {Height}; этажность: {Floor}; количество квартир: {Flat}; количества подъездов: {Etrance};");
        }


    }

    public class Creator :Building
    {
        static Hashtable city = new Hashtable();
        static ICollection key = city.Keys;
        static int counter=1;

        Creator()
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

        public static void DeleteBuild()
        {

        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            Creator.CreateBuild(15, 10, 8);
            Creator.CreateBuild(8, 9, 41);
            Creator.CreateBuild(45, 1, 88);
            Creator.CreateBuild(45, 1, 88);
            Creator.CreateBuild(45, 1, 88);

            Creator.CityPrint();


        }
    }
}
