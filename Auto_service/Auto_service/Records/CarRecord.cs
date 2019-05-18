using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service.Records
{
    class CarRecord : Record
    {
        private int userId;
        private string name;
        private string body_type;
        private string fuel_type;
        private int motor_power;
        private int manufacture_year;

        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Body_type
        {
            get
            {
                return body_type;
            }
            set
            {
                body_type = value;
            }
        }
        public string Fuel_type
        {
            get
            {
                return fuel_type;
            }
            set
            {
                fuel_type = value;
            }
        }
        public int Motor_power
        {
            get
            {
                return motor_power;
            }
            set
            {
                motor_power = value;
            }
        }
        public int Manufacture_year
        {
            get
            {
                return manufacture_year;
            }
            set
            {
                manufacture_year = value;
            }
        }

        public CarRecord()
        {

        }
        public CarRecord(string Name, string Body_Type, string Fuel_Type, int Motor_Power, int Manufacture_Year)
            : base()
        {
            this.name = Name;
            this.body_type = Body_Type;
            this.fuel_type = Fuel_Type;
            this.motor_power = Motor_Power;
            this.manufacture_year = Manufacture_Year;
        }

        public CarRecord(long? id)
            : base(id)
        {

        }
    }
}
