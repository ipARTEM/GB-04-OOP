using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_04_06Task6Test
{
    public class MotorVehicle : Vehicle
    {
        /// <summary>
        /// Оставшееся топливо
        /// </summary>
        private float _fuelRemaining;

        /// <summary>
        /// Размер бака 
        /// </summary>
        private float _tankSize;

        public float FuelRemaining
        {
            get { return _fuelRemaining; }
        }

        /// <summary>
        /// Размер бака 
        /// </summary>
        public float TankSize
        {
            get { return _tankSize; }
            set { _tankSize = value; }
        }

        /// <summary>
        /// Заправиться
        /// </summary>
        /// <returns></returns>
        public float Refuel()
        {
            float fuelRequired = _tankSize - _fuelRemaining;
            _fuelRemaining = _tankSize;
            return fuelRequired;
        }

        public override void Indicate(bool turningLeft)
        {
            if (turningLeft)
                Console.WriteLine("Flashing left indicator");
            else
                Console.WriteLine("Flashing right indicator");
        }



    }
}
