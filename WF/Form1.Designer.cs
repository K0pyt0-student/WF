
namespace WF
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // PickupRB
            // 
            this.PickupRB.AutoSize = true;
            this.PickupRB.Location = new System.Drawing.Point(96, 95);
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
            this.BigWeightRB.Location = new System.Drawing.Point(96, 150);
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
            this.TrainRB.Location = new System.Drawing.Point(96, 207);
            this.TrainRB.Name = "TrainRB";
            this.TrainRB.Size = new System.Drawing.Size(110, 19);
            this.TrainRB.TabIndex = 2;
            this.TrainRB.Text = "Грузовой поезд";
            this.TrainRB.UseVisualStyleBackColor = true;
            this.TrainRB.CheckedChanged += new System.EventHandler(this.TrainRB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrainRB);
            this.Controls.Add(this.BigWeightRB);
            this.Controls.Add(this.PickupRB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton PickupRB;
        private System.Windows.Forms.RadioButton BigWeightRB;
        private System.Windows.Forms.RadioButton TrainRB;
    }
}

