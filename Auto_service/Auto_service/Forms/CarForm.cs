using Auto_service.Managers;
using Auto_service.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_service.Forms
{
    public partial class CarForm : Form
    {
        private CarManager carManager = new CarManager();
        public CarForm()
        {
            InitializeComponent();
            fillCarsAsCarRecordsFromRecords();
        }

        private void button_add_car_Click(object sender, EventArgs e)
        {

            //try
            //{
            string name = textBox_name.Text;
            string body_type = textBox_body_type.Text;
            string fuel_type = textBox_fuel_type.Text;
            int motor_power = Convert.ToInt32(textBox_motor_power.Text);
            int manufacture_year = Convert.ToInt32(textBox_manufacture_year.Text);

            CarRecord car = new CarRecord(name, body_type, fuel_type, motor_power, manufacture_year);
            if (!DoesCarAlreadyExists(car))
            {
                carManager.CarsAsCarRecords.Add(car);
                carManager.Insert(car);
                MessageBox.Show("Sikeres rögzítés!");
            }
            else
            {
                MessageBox.Show("Már létezik ilyen autó.");
                EmptyTheTextBoxes();
            }

            //}
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Sikertelen rögzítés." + ex.Message);
            //    }
        }
        private void fillCarsAsCarRecordsFromRecords()
        {
            List<Record> carsAsRecords = carManager.Select();

            foreach (var record in carsAsRecords)
            {
                CarRecord carRecord = new CarRecord();
                carRecord.Name = (record as CarRecord).Name;
                carRecord.UserId = (record as CarRecord).UserId;
                carRecord.Fuel_type = (record as CarRecord).Fuel_type;
                carRecord.Body_type = (record as CarRecord).Body_type;
                carRecord.Manufacture_year = (record as CarRecord).Manufacture_year;
                carRecord.Motor_power = (record as CarRecord).Motor_power;

                carManager.CarsAsCarRecords.Add(carRecord);
            }
        }
        private bool DoesCarAlreadyExists(CarRecord car)
        {
            bool exists = false;
            int id = Convert.ToInt32(car.Id);
            foreach (var item in carManager.CarsAsCarRecords)
            {
                if (id == item.Id)
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }
        private void EmptyTheTextBoxes()
        {
            textBox_body_type.Text = "";
            textBox_fuel_type.Text = "";
            textBox_manufacture_year.Text = "";
            textBox_motor_power.Text = "";
            textBox_name.Text = "";
        }
    }
}
