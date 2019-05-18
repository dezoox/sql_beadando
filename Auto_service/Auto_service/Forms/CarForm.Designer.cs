namespace Auto_service.Forms
{
    partial class CarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_car = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_body_type = new System.Windows.Forms.TextBox();
            this.textBox_fuel_type = new System.Windows.Forms.TextBox();
            this.textBox_motor_power = new System.Windows.Forms.TextBox();
            this.textBox_manufacture_year = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autó hozzáadása";
            // 
            // button_add_car
            // 
            this.button_add_car.Location = new System.Drawing.Point(49, 175);
            this.button_add_car.Name = "button_add_car";
            this.button_add_car.Size = new System.Drawing.Size(75, 23);
            this.button_add_car.TabIndex = 1;
            this.button_add_car.Text = "Hozzáadás";
            this.button_add_car.UseVisualStyleBackColor = true;
            this.button_add_car.Click += new System.EventHandler(this.button_add_car_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(96, 32);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_body_type
            // 
            this.textBox_body_type.Location = new System.Drawing.Point(96, 58);
            this.textBox_body_type.Name = "textBox_body_type";
            this.textBox_body_type.Size = new System.Drawing.Size(100, 20);
            this.textBox_body_type.TabIndex = 3;
            // 
            // textBox_fuel_type
            // 
            this.textBox_fuel_type.Location = new System.Drawing.Point(96, 84);
            this.textBox_fuel_type.Name = "textBox_fuel_type";
            this.textBox_fuel_type.Size = new System.Drawing.Size(100, 20);
            this.textBox_fuel_type.TabIndex = 4;
            // 
            // textBox_motor_power
            // 
            this.textBox_motor_power.Location = new System.Drawing.Point(96, 110);
            this.textBox_motor_power.Name = "textBox_motor_power";
            this.textBox_motor_power.Size = new System.Drawing.Size(100, 20);
            this.textBox_motor_power.TabIndex = 5;
            // 
            // textBox_manufacture_year
            // 
            this.textBox_manufacture_year.Location = new System.Drawing.Point(96, 136);
            this.textBox_manufacture_year.Name = "textBox_manufacture_year";
            this.textBox_manufacture_year.Size = new System.Drawing.Size(100, 20);
            this.textBox_manufacture_year.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Autó neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Autó típusa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Üzemanyag:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Motor teljesítmény:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gyártási év:";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_manufacture_year);
            this.Controls.Add(this.textBox_motor_power);
            this.Controls.Add(this.textBox_fuel_type);
            this.Controls.Add(this.textBox_body_type);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_add_car);
            this.Controls.Add(this.label1);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_car;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_body_type;
        private System.Windows.Forms.TextBox textBox_fuel_type;
        private System.Windows.Forms.TextBox textBox_motor_power;
        private System.Windows.Forms.TextBox textBox_manufacture_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}