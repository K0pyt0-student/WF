
namespace WF
{
    partial class Weeweee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PickupRB = new System.Windows.Forms.RadioButton();
            this.BigWeightRB = new System.Windows.Forms.RadioButton();
            this.TrainRB = new System.Windows.Forms.RadioButton();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.CarsAmTB = new System.Windows.Forms.TextBox();
            this.CarsAmLB = new System.Windows.Forms.Label();
            this.TanksAmTB = new System.Windows.Forms.TextBox();
            this.TanksAmLB = new System.Windows.Forms.Label();
            this.PassengerCB = new System.Windows.Forms.CheckBox();
            this.DriversNumTB = new System.Windows.Forms.TextBox();
            this.DriveTypeTB = new System.Windows.Forms.TextBox();
            this.WheelAmTB = new System.Windows.Forms.TextBox();
            this.DriversNumLB = new System.Windows.Forms.Label();
            this.DriveTypeLB = new System.Windows.Forms.Label();
            this.WheelAmLB = new System.Windows.Forms.Label();
            this.RedactBT = new System.Windows.Forms.Button();
            this.CreateBT = new System.Windows.Forms.Button();
            this.CargoWtTB = new System.Windows.Forms.TextBox();
            this.cargoWtLB = new System.Windows.Forms.Label();
            this.MaxWtTB = new System.Windows.Forms.TextBox();
            this.MaxWtLB = new System.Windows.Forms.Label();
            this.DistanceTB = new System.Windows.Forms.TextBox();
            this.DistanceLB = new System.Windows.Forms.Label();
            this.TrnsWtTB = new System.Windows.Forms.TextBox();
            this.TrnsWtLB = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NameLB = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.CargoWtPrintLB = new System.Windows.Forms.Label();
            this.DistancePrintLB = new System.Windows.Forms.Label();
            this.FullWtLB = new System.Windows.Forms.Label();
            this.InputPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PickupRB
            // 
            this.PickupRB.AutoSize = true;
            this.PickupRB.Location = new System.Drawing.Point(50, 47);
            this.PickupRB.Name = "PickupRB";
            this.PickupRB.Size = new System.Drawing.Size(60, 19);
            this.PickupRB.TabIndex = 0;
            this.PickupRB.Text = "Пикап";
            this.PickupRB.UseVisualStyleBackColor = true;
            this.PickupRB.CheckedChanged += new System.EventHandler(this.PickupRB_CheckedChanged);
            // 
            // BigWeightRB
            // 
            this.BigWeightRB.AutoSize = true;
            this.BigWeightRB.Location = new System.Drawing.Point(116, 47);
            this.BigWeightRB.Name = "BigWeightRB";
            this.BigWeightRB.Size = new System.Drawing.Size(92, 19);
            this.BigWeightRB.TabIndex = 1;
            this.BigWeightRB.Text = "Большегруз\r\n";
            this.BigWeightRB.UseVisualStyleBackColor = true;
            this.BigWeightRB.CheckedChanged += new System.EventHandler(this.BigWeightRB_CheckedChanged);
            // 
            // TrainRB
            // 
            this.TrainRB.AutoSize = true;
            this.TrainRB.Location = new System.Drawing.Point(214, 47);
            this.TrainRB.Name = "TrainRB";
            this.TrainRB.Size = new System.Drawing.Size(110, 19);
            this.TrainRB.TabIndex = 2;
            this.TrainRB.Text = "Грузовой поезд";
            this.TrainRB.UseVisualStyleBackColor = true;
            this.TrainRB.CheckedChanged += new System.EventHandler(this.TrainRB_CheckedChanged);
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.CarsAmTB);
            this.InputPanel.Controls.Add(this.CarsAmLB);
            this.InputPanel.Controls.Add(this.TanksAmTB);
            this.InputPanel.Controls.Add(this.TanksAmLB);
            this.InputPanel.Controls.Add(this.PassengerCB);
            this.InputPanel.Controls.Add(this.DriversNumTB);
            this.InputPanel.Controls.Add(this.DriveTypeTB);
            this.InputPanel.Controls.Add(this.WheelAmTB);
            this.InputPanel.Controls.Add(this.DriversNumLB);
            this.InputPanel.Controls.Add(this.DriveTypeLB);
            this.InputPanel.Controls.Add(this.WheelAmLB);
            this.InputPanel.Controls.Add(this.RedactBT);
            this.InputPanel.Controls.Add(this.CreateBT);
            this.InputPanel.Controls.Add(this.CargoWtTB);
            this.InputPanel.Controls.Add(this.cargoWtLB);
            this.InputPanel.Controls.Add(this.MaxWtTB);
            this.InputPanel.Controls.Add(this.MaxWtLB);
            this.InputPanel.Controls.Add(this.DistanceTB);
            this.InputPanel.Controls.Add(this.DistanceLB);
            this.InputPanel.Controls.Add(this.TrnsWtTB);
            this.InputPanel.Controls.Add(this.TrnsWtLB);
            this.InputPanel.Controls.Add(this.NameTB);
            this.InputPanel.Controls.Add(this.NameLB);
            this.InputPanel.Location = new System.Drawing.Point(50, 72);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(274, 366);
            this.InputPanel.TabIndex = 3;
            // 
            // CarsAmTB
            // 
            this.CarsAmTB.Location = new System.Drawing.Point(141, 206);
            this.CarsAmTB.Name = "CarsAmTB";
            this.CarsAmTB.Size = new System.Drawing.Size(130, 23);
            this.CarsAmTB.TabIndex = 23;
            // 
            // CarsAmLB
            // 
            this.CarsAmLB.AutoSize = true;
            this.CarsAmLB.Location = new System.Drawing.Point(3, 209);
            this.CarsAmLB.Name = "CarsAmLB";
            this.CarsAmLB.Size = new System.Drawing.Size(89, 15);
            this.CarsAmLB.TabIndex = 22;
            this.CarsAmLB.Text = "Число вагонов";
            // 
            // TanksAmTB
            // 
            this.TanksAmTB.Location = new System.Drawing.Point(141, 233);
            this.TanksAmTB.Name = "TanksAmTB";
            this.TanksAmTB.Size = new System.Drawing.Size(130, 23);
            this.TanksAmTB.TabIndex = 21;
            // 
            // TanksAmLB
            // 
            this.TanksAmLB.AutoSize = true;
            this.TanksAmLB.Location = new System.Drawing.Point(3, 236);
            this.TanksAmLB.Name = "TanksAmLB";
            this.TanksAmLB.Size = new System.Drawing.Size(77, 15);
            this.TanksAmLB.TabIndex = 20;
            this.TanksAmLB.Text = "Число баков";
            // 
            // PassengerCB
            // 
            this.PassengerCB.AutoSize = true;
            this.PassengerCB.Location = new System.Drawing.Point(141, 235);
            this.PassengerCB.Name = "PassengerCB";
            this.PassengerCB.Size = new System.Drawing.Size(111, 19);
            this.PassengerCB.TabIndex = 19;
            this.PassengerCB.Text = "Есть пассажир?";
            this.PassengerCB.UseVisualStyleBackColor = true;
            // 
            // DriversNumTB
            // 
            this.DriversNumTB.Location = new System.Drawing.Point(141, 206);
            this.DriversNumTB.Name = "DriversNumTB";
            this.DriversNumTB.Size = new System.Drawing.Size(130, 23);
            this.DriversNumTB.TabIndex = 17;
            // 
            // DriveTypeTB
            // 
            this.DriveTypeTB.Location = new System.Drawing.Point(141, 177);
            this.DriveTypeTB.Name = "DriveTypeTB";
            this.DriveTypeTB.Size = new System.Drawing.Size(130, 23);
            this.DriveTypeTB.TabIndex = 16;
            // 
            // WheelAmTB
            // 
            this.WheelAmTB.Location = new System.Drawing.Point(141, 148);
            this.WheelAmTB.Name = "WheelAmTB";
            this.WheelAmTB.Size = new System.Drawing.Size(130, 23);
            this.WheelAmTB.TabIndex = 15;
            // 
            // DriversNumLB
            // 
            this.DriversNumLB.AutoSize = true;
            this.DriversNumLB.Location = new System.Drawing.Point(3, 209);
            this.DriversNumLB.Name = "DriversNumLB";
            this.DriversNumLB.Size = new System.Drawing.Size(132, 15);
            this.DriversNumLB.TabIndex = 14;
            this.DriversNumLB.Text = "Количество водителей";
            // 
            // DriveTypeLB
            // 
            this.DriveTypeLB.AutoSize = true;
            this.DriveTypeLB.Location = new System.Drawing.Point(3, 180);
            this.DriveTypeLB.Name = "DriveTypeLB";
            this.DriveTypeLB.Size = new System.Drawing.Size(78, 15);
            this.DriveTypeLB.TabIndex = 13;
            this.DriveTypeLB.Text = "ТипПривода:";
            // 
            // WheelAmLB
            // 
            this.WheelAmLB.AutoSize = true;
            this.WheelAmLB.Location = new System.Drawing.Point(4, 151);
            this.WheelAmLB.Name = "WheelAmLB";
            this.WheelAmLB.Size = new System.Drawing.Size(113, 15);
            this.WheelAmLB.TabIndex = 12;
            this.WheelAmLB.Text = "Количество колёс: ";
            // 
            // RedactBT
            // 
            this.RedactBT.Location = new System.Drawing.Point(28, 311);
            this.RedactBT.Name = "RedactBT";
            this.RedactBT.Size = new System.Drawing.Size(217, 23);
            this.RedactBT.TabIndex = 11;
            this.RedactBT.Text = "Редктировать транспорт";
            this.RedactBT.UseVisualStyleBackColor = true;
            // 
            // CreateBT
            // 
            this.CreateBT.Location = new System.Drawing.Point(28, 340);
            this.CreateBT.Name = "CreateBT";
            this.CreateBT.Size = new System.Drawing.Size(217, 23);
            this.CreateBT.TabIndex = 10;
            this.CreateBT.Text = "Создать транспорт";
            this.CreateBT.UseVisualStyleBackColor = true;
            this.CreateBT.Click += new System.EventHandler(this.CreateButtonPressed);
            // 
            // CargoWtTB
            // 
            this.CargoWtTB.Location = new System.Drawing.Point(141, 119);
            this.CargoWtTB.Name = "CargoWtTB";
            this.CargoWtTB.Size = new System.Drawing.Size(130, 23);
            this.CargoWtTB.TabIndex = 9;
            // 
            // cargoWtLB
            // 
            this.cargoWtLB.AutoSize = true;
            this.cargoWtLB.Location = new System.Drawing.Point(3, 122);
            this.cargoWtLB.Name = "cargoWtLB";
            this.cargoWtLB.Size = new System.Drawing.Size(80, 15);
            this.cargoWtLB.TabIndex = 8;
            this.cargoWtLB.Text = "Масса груза: ";
            // 
            // MaxWtTB
            // 
            this.MaxWtTB.Location = new System.Drawing.Point(141, 90);
            this.MaxWtTB.Name = "MaxWtTB";
            this.MaxWtTB.Size = new System.Drawing.Size(130, 23);
            this.MaxWtTB.TabIndex = 7;
            // 
            // MaxWtLB
            // 
            this.MaxWtLB.AutoSize = true;
            this.MaxWtLB.Location = new System.Drawing.Point(3, 93);
            this.MaxWtLB.Name = "MaxWtLB";
            this.MaxWtLB.Size = new System.Drawing.Size(114, 15);
            this.MaxWtLB.TabIndex = 6;
            this.MaxWtLB.Text = "Грузоподъемность:";
            // 
            // DistanceTB
            // 
            this.DistanceTB.Location = new System.Drawing.Point(141, 61);
            this.DistanceTB.Name = "DistanceTB";
            this.DistanceTB.Size = new System.Drawing.Size(130, 23);
            this.DistanceTB.TabIndex = 5;
            // 
            // DistanceLB
            // 
            this.DistanceLB.AutoSize = true;
            this.DistanceLB.Location = new System.Drawing.Point(3, 64);
            this.DistanceLB.Name = "DistanceLB";
            this.DistanceLB.Size = new System.Drawing.Size(70, 15);
            this.DistanceLB.TabIndex = 4;
            this.DistanceLB.Text = "Запас хода:";
            // 
            // TrnsWtTB
            // 
            this.TrnsWtTB.Location = new System.Drawing.Point(141, 32);
            this.TrnsWtTB.Name = "TrnsWtTB";
            this.TrnsWtTB.Size = new System.Drawing.Size(130, 23);
            this.TrnsWtTB.TabIndex = 3;
            // 
            // TrnsWtLB
            // 
            this.TrnsWtLB.AutoSize = true;
            this.TrnsWtLB.Location = new System.Drawing.Point(3, 35);
            this.TrnsWtLB.Name = "TrnsWtLB";
            this.TrnsWtLB.Size = new System.Drawing.Size(62, 15);
            this.TrnsWtLB.TabIndex = 2;
            this.TrnsWtLB.Text = "Масса ТС:";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(141, 3);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(130, 23);
            this.NameTB.TabIndex = 1;
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Location = new System.Drawing.Point(3, 6);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(65, 15);
            this.NameLB.TabIndex = 0;
            this.NameLB.Text = "Название: ";
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.CargoWtPrintLB);
            this.OutputPanel.Controls.Add(this.DistancePrintLB);
            this.OutputPanel.Controls.Add(this.FullWtLB);
            this.OutputPanel.Location = new System.Drawing.Point(330, 72);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(340, 365);
            this.OutputPanel.TabIndex = 4;
            // 
            // CargoWtPrintLB
            // 
            this.CargoWtPrintLB.AutoSize = true;
            this.CargoWtPrintLB.Location = new System.Drawing.Point(3, 64);
            this.CargoWtPrintLB.Name = "CargoWtPrintLB";
            this.CargoWtPrintLB.Size = new System.Drawing.Size(80, 15);
            this.CargoWtPrintLB.TabIndex = 2;
            this.CargoWtPrintLB.Text = "Масса груза: ";
            // 
            // DistancePrintLB
            // 
            this.DistancePrintLB.AutoSize = true;
            this.DistancePrintLB.Location = new System.Drawing.Point(3, 35);
            this.DistancePrintLB.Name = "DistancePrintLB";
            this.DistancePrintLB.Size = new System.Drawing.Size(184, 15);
            this.DistancePrintLB.TabIndex = 1;
            this.DistancePrintLB.Text = "Запас хода с данной нагрузкой: ";
            // 
            // FullWtLB
            // 
            this.FullWtLB.AutoSize = true;
            this.FullWtLB.Location = new System.Drawing.Point(3, 6);
            this.FullWtLB.Name = "FullWtLB";
            this.FullWtLB.Size = new System.Drawing.Size(91, 15);
            this.FullWtLB.TabIndex = 0;
            this.FullWtLB.Text = "Полная масса: ";
            // 
            // Weeweee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.TrainRB);
            this.Controls.Add(this.BigWeightRB);
            this.Controls.Add(this.PickupRB);
            this.Name = "Weeweee";
            this.Text = "♂Wee-wee♂";
            this.Load += new System.EventHandler(this.InputPanelLoaded);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton PickupRB;
        private System.Windows.Forms.RadioButton BigWeightRB;
        private System.Windows.Forms.RadioButton TrainRB;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.TextBox CargoWtTB;
        private System.Windows.Forms.Label cargoWtLB;
        private System.Windows.Forms.TextBox MaxWtTB;
        private System.Windows.Forms.Label MaxWtLB;
        private System.Windows.Forms.TextBox DistanceTB;
        private System.Windows.Forms.Label DistanceLB;
        private System.Windows.Forms.TextBox TrnsWtTB;
        private System.Windows.Forms.Label TrnsWtLB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button CreateBT;
        private System.Windows.Forms.Button RedactBT;
        private System.Windows.Forms.Label DriversNumLB;
        private System.Windows.Forms.Label DriveTypeLB;
        private System.Windows.Forms.Label WheelAmLB;
        private System.Windows.Forms.CheckBox PassengerCB;
        private System.Windows.Forms.TextBox DriversNumTB;
        private System.Windows.Forms.TextBox DriveTypeTB;
        private System.Windows.Forms.TextBox WheelAmTB;
        private System.Windows.Forms.TextBox CarsAmTB;
        private System.Windows.Forms.Label CarsAmLB;
        private System.Windows.Forms.TextBox TanksAmTB;
        private System.Windows.Forms.Label TanksAmLB;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label FullWtLB;
        private System.Windows.Forms.Label DistancePrintLB;
        private System.Windows.Forms.Label CargoWtPrintLB;
    }
}

