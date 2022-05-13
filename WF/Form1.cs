using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Weeweee : Form
    {
        public Weeweee()
        {
            InitializeComponent();
            
        }
        CargoTransport obj;
        private void PickupRB_CheckedChanged(object sender, EventArgs e)
        {
            InputPanel.Visible = true;
            OutputPanel.Visible = true;
            RedactBT.Visible = false;

            DriversNumLB.Visible = false;
            DriversNumTB.Visible = false;
            PassengerCB.Visible = false;
            CarsAmLB.Visible = false;
            CarsAmTB.Visible = false;
            TanksAmLB.Visible = false;
            TanksAmTB.Visible = false;
            CargoWtPrintLB.Visible = false;
            if (PickupRB.Checked == true)
            {
                DriversNumLB.Visible = true;
                DriversNumTB.Visible = true;
                PassengerCB.Visible = true;
            }


        }

        private void BigWeightRB_CheckedChanged(object sender, EventArgs e)
        {
            InputPanel.Visible = true;
            OutputPanel.Visible = true;
            RedactBT.Visible = false;

            DriversNumLB.Visible = false;
            DriversNumTB.Visible = false;
            PassengerCB.Visible = false;
            CarsAmLB.Visible = false;
            CarsAmTB.Visible = false;
            TanksAmLB.Visible = false;
            TanksAmTB.Visible = false;
            CargoWtPrintLB.Visible = false;
            if (BigWeightRB.Checked == true)
            {
                DriversNumLB.Visible = true;
                DriversNumTB.Visible = true;
                TanksAmLB.Visible = true;
                TanksAmTB.Visible = true;
            }
        }

        private void TrainRB_CheckedChanged(object sender, EventArgs e)
        {
            InputPanel.Visible = true;
            OutputPanel.Visible = true;
            RedactBT.Visible = false;

            DriversNumLB.Visible = false;
            DriversNumTB.Visible = false;
            PassengerCB.Visible = false;
            CarsAmLB.Visible = false;
            CarsAmTB.Visible = false;
            TanksAmLB.Visible = false;
            TanksAmTB.Visible = false;
            if (TrainRB.Checked == true)
            {
                CarsAmLB.Visible = true;
                CarsAmTB.Visible = true;
            }
        }



        private void InputPanelLoaded(object sender, EventArgs e)
        {
            InputPanel.Visible = false;
        }

        private void CreateButtonPressed(object sender, EventArgs e)
        {

            try
            {
                if (PickupRB.Checked)
                {
                    int driveType = int.Parse(DriveTypeTB.Text);
                    if (driveType > 3) throw new Exception("Неправильный привод");
                    obj = new Pickup(NameTB.Text, 
                    int.Parse(TrnsWtTB.Text), 
                    int.Parse(DistanceTB.Text), 
                    int.Parse(MaxWtTB.Text), 
                    int.Parse(CargoWtTB.Text),
                    int.Parse(WheelAmTB.Text), 
                    driveType, 
                    int.Parse(DriversNumTB.Text),
                    PassengerCB.Checked);
                }
                else if (BigWeightRB.Checked)
                {
                    int driveType = int.Parse(DriveTypeTB.Text);
                    if (driveType > 3) throw new Exception("Неправильный привод");
                    obj = new BigWeight(NameTB.Text,
                    int.Parse(TrnsWtTB.Text),
                    int.Parse(DistanceTB.Text),
                    int.Parse(MaxWtTB.Text),
                    int.Parse(CargoWtTB.Text),
                    int.Parse(WheelAmTB.Text),
                    driveType,
                    int.Parse(DriversNumTB.Text),
                    int.Parse(TanksAmTB.Text));
                }
                else if (TrainRB.Checked)
                {
                    /*int driveType = int.Parse(DriveTypeTB.Text);
                    if (driveType > 3) throw new Exception("Неправильный привод");
                    obj = new Train(NameTB.Text,
                    int.Parse(TrnsWtTB.Text),
                    int.Parse(DistanceTB.Text),
                    int.Parse(MaxWtTB.Text),
                    int.Parse(CargoWtTB.Text),
                    int.Parse(WheelAmTB.Text),
                    driveType,
                    int.Parse(CarsAmTB.Text));*/
                }
                RedactBT.Visible = true;
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так. Проверьте правильность всех данных.");
            }
        }
        }
    }
