using System;

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
}
