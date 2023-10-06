namespace Hotel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLux = new System.Windows.Forms.RadioButton();
            this.rdStandart = new System.Windows.Forms.RadioButton();
            this.rdEconom = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckDinner = new System.Windows.Forms.CheckBox();
            this.ckLunch = new System.Windows.Forms.CheckBox();
            this.ckBreakfast = new System.Windows.Forms.CheckBox();
            this.ckElectricRefueling = new System.Windows.Forms.CheckBox();
            this.ckWiFi = new System.Windows.Forms.CheckBox();
            this.ckSPA = new System.Windows.Forms.CheckBox();
            this.ckPool = new System.Windows.Forms.CheckBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblPeriodOfStay = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtPeriodOfStay = new System.Windows.Forms.TextBox();
            this.lblFinalRate = new System.Windows.Forms.Label();
            this.txtFinalRate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdTripleRoom = new System.Windows.Forms.RadioButton();
            this.rdDoubleRoom = new System.Windows.Forms.RadioButton();
            this.rdSingleRoom = new System.Windows.Forms.RadioButton();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLux);
            this.groupBox1.Controls.Add(this.rdStandart);
            this.groupBox1.Controls.Add(this.rdEconom);
            this.groupBox1.Location = new System.Drawing.Point(49, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdLux
            // 
            this.rdLux.AutoSize = true;
            this.rdLux.Location = new System.Drawing.Point(24, 73);
            this.rdLux.Name = "rdLux";
            this.rdLux.Size = new System.Drawing.Size(44, 19);
            this.rdLux.TabIndex = 2;
            this.rdLux.TabStop = true;
            this.rdLux.Text = "Lux";
            this.rdLux.UseVisualStyleBackColor = true;
            this.rdLux.CheckedChanged += new System.EventHandler(this.rdLux_CheckedChanged);
            // 
            // rdStandart
            // 
            this.rdStandart.AutoSize = true;
            this.rdStandart.Location = new System.Drawing.Point(24, 48);
            this.rdStandart.Name = "rdStandart";
            this.rdStandart.Size = new System.Drawing.Size(69, 19);
            this.rdStandart.TabIndex = 1;
            this.rdStandart.TabStop = true;
            this.rdStandart.Text = "Standart";
            this.rdStandart.UseVisualStyleBackColor = true;
            this.rdStandart.CheckedChanged += new System.EventHandler(this.rdStandart_CheckedChanged);
            // 
            // rdEconom
            // 
            this.rdEconom.AutoSize = true;
            this.rdEconom.Location = new System.Drawing.Point(24, 23);
            this.rdEconom.Name = "rdEconom";
            this.rdEconom.Size = new System.Drawing.Size(69, 19);
            this.rdEconom.TabIndex = 0;
            this.rdEconom.TabStop = true;
            this.rdEconom.Text = "Econom";
            this.rdEconom.UseVisualStyleBackColor = true;
            this.rdEconom.CheckedChanged += new System.EventHandler(this.rdEconom_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckDinner);
            this.groupBox2.Controls.Add(this.ckLunch);
            this.groupBox2.Controls.Add(this.ckBreakfast);
            this.groupBox2.Controls.Add(this.ckElectricRefueling);
            this.groupBox2.Controls.Add(this.ckWiFi);
            this.groupBox2.Controls.Add(this.ckSPA);
            this.groupBox2.Controls.Add(this.ckPool);
            this.groupBox2.Location = new System.Drawing.Point(49, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // ckDinner
            // 
            this.ckDinner.AutoSize = true;
            this.ckDinner.Location = new System.Drawing.Point(24, 170);
            this.ckDinner.Name = "ckDinner";
            this.ckDinner.Size = new System.Drawing.Size(61, 19);
            this.ckDinner.TabIndex = 7;
            this.ckDinner.Text = "Dinner";
            this.ckDinner.UseVisualStyleBackColor = true;
            // 
            // ckLunch
            // 
            this.ckLunch.AutoSize = true;
            this.ckLunch.Location = new System.Drawing.Point(23, 145);
            this.ckLunch.Name = "ckLunch";
            this.ckLunch.Size = new System.Drawing.Size(59, 19);
            this.ckLunch.TabIndex = 6;
            this.ckLunch.Text = "Lunch";
            this.ckLunch.UseVisualStyleBackColor = true;
            // 
            // ckBreakfast
            // 
            this.ckBreakfast.AutoSize = true;
            this.ckBreakfast.Location = new System.Drawing.Point(23, 120);
            this.ckBreakfast.Name = "ckBreakfast";
            this.ckBreakfast.Size = new System.Drawing.Size(74, 19);
            this.ckBreakfast.TabIndex = 5;
            this.ckBreakfast.Text = "Breakfast";
            this.ckBreakfast.UseVisualStyleBackColor = true;
            // 
            // ckElectricRefueling
            // 
            this.ckElectricRefueling.AutoSize = true;
            this.ckElectricRefueling.Location = new System.Drawing.Point(23, 95);
            this.ckElectricRefueling.Name = "ckElectricRefueling";
            this.ckElectricRefueling.Size = new System.Drawing.Size(114, 19);
            this.ckElectricRefueling.TabIndex = 4;
            this.ckElectricRefueling.Text = "ElectricRefueling";
            this.ckElectricRefueling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckElectricRefueling.UseVisualStyleBackColor = true;
            // 
            // ckWiFi
            // 
            this.ckWiFi.AutoSize = true;
            this.ckWiFi.Location = new System.Drawing.Point(23, 43);
            this.ckWiFi.Name = "ckWiFi";
            this.ckWiFi.Size = new System.Drawing.Size(49, 19);
            this.ckWiFi.TabIndex = 3;
            this.ckWiFi.Text = "WiFi";
            this.ckWiFi.UseVisualStyleBackColor = true;
            // 
            // ckSPA
            // 
            this.ckSPA.AutoSize = true;
            this.ckSPA.Location = new System.Drawing.Point(23, 68);
            this.ckSPA.Name = "ckSPA";
            this.ckSPA.Size = new System.Drawing.Size(46, 19);
            this.ckSPA.TabIndex = 2;
            this.ckSPA.Text = "SPA";
            this.ckSPA.UseVisualStyleBackColor = true;
            // 
            // ckPool
            // 
            this.ckPool.AutoSize = true;
            this.ckPool.Location = new System.Drawing.Point(23, 18);
            this.ckPool.Name = "ckPool";
            this.ckPool.Size = new System.Drawing.Size(50, 19);
            this.ckPool.TabIndex = 0;
            this.ckPool.Text = "Pool";
            this.ckPool.UseVisualStyleBackColor = true;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(304, 171);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(62, 15);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Room rate";
            // 
            // lblPeriodOfStay
            // 
            this.lblPeriodOfStay.AutoSize = true;
            this.lblPeriodOfStay.Location = new System.Drawing.Point(304, 200);
            this.lblPeriodOfStay.Name = "lblPeriodOfStay";
            this.lblPeriodOfStay.Size = new System.Drawing.Size(82, 15);
            this.lblPeriodOfStay.TabIndex = 3;
            this.lblPeriodOfStay.Text = "Period Of Stay";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(401, 168);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(100, 23);
            this.txtRate.TabIndex = 4;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // txtPeriodOfStay
            // 
            this.txtPeriodOfStay.Location = new System.Drawing.Point(401, 197);
            this.txtPeriodOfStay.Name = "txtPeriodOfStay";
            this.txtPeriodOfStay.Size = new System.Drawing.Size(100, 23);
            this.txtPeriodOfStay.TabIndex = 5;
            this.txtPeriodOfStay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_number_KeyPress);
            // 
            // lblFinalRate
            // 
            this.lblFinalRate.AutoSize = true;
            this.lblFinalRate.Location = new System.Drawing.Point(326, 304);
            this.lblFinalRate.Name = "lblFinalRate";
            this.lblFinalRate.Size = new System.Drawing.Size(58, 15);
            this.lblFinalRate.TabIndex = 6;
            this.lblFinalRate.Text = "Final Rate";
            // 
            // txtFinalRate
            // 
            this.txtFinalRate.Location = new System.Drawing.Point(401, 304);
            this.txtFinalRate.Name = "txtFinalRate";
            this.txtFinalRate.ReadOnly = true;
            this.txtFinalRate.Size = new System.Drawing.Size(100, 23);
            this.txtFinalRate.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTripleRoom);
            this.groupBox3.Controls.Add(this.rdDoubleRoom);
            this.groupBox3.Controls.Add(this.rdSingleRoom);
            this.groupBox3.Location = new System.Drawing.Point(319, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rdTripleRoom
            // 
            this.rdTripleRoom.AutoSize = true;
            this.rdTripleRoom.Location = new System.Drawing.Point(24, 73);
            this.rdTripleRoom.Name = "rdTripleRoom";
            this.rdTripleRoom.Size = new System.Drawing.Size(88, 19);
            this.rdTripleRoom.TabIndex = 2;
            this.rdTripleRoom.TabStop = true;
            this.rdTripleRoom.Text = "Triple Room";
            this.rdTripleRoom.UseVisualStyleBackColor = true;
            // 
            // rdDoubleRoom
            // 
            this.rdDoubleRoom.AutoSize = true;
            this.rdDoubleRoom.Location = new System.Drawing.Point(24, 48);
            this.rdDoubleRoom.Name = "rdDoubleRoom";
            this.rdDoubleRoom.Size = new System.Drawing.Size(98, 19);
            this.rdDoubleRoom.TabIndex = 1;
            this.rdDoubleRoom.TabStop = true;
            this.rdDoubleRoom.Text = "Double Room";
            this.rdDoubleRoom.UseVisualStyleBackColor = true;
            // 
            // rdSingleRoom
            // 
            this.rdSingleRoom.AutoSize = true;
            this.rdSingleRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdSingleRoom.Location = new System.Drawing.Point(24, 23);
            this.rdSingleRoom.Name = "rdSingleRoom";
            this.rdSingleRoom.Size = new System.Drawing.Size(92, 19);
            this.rdSingleRoom.TabIndex = 0;
            this.rdSingleRoom.TabStop = true;
            this.rdSingleRoom.Text = "Single Room";
            this.rdSingleRoom.UseVisualStyleBackColor = true;
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(314, 247);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(187, 34);
            this.btnCalculation.TabIndex = 8;
            this.btnCalculation.Text = "Calculation";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtFinalRate);
            this.Controls.Add(this.lblFinalRate);
            this.Controls.Add(this.txtPeriodOfStay);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblPeriodOfStay);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdLux;
        private RadioButton rdStandart;
        private RadioButton rdEconom;
        private GroupBox groupBox2;
        private CheckBox ckSPA;
        private CheckBox ckPool;
        private Label lblRate;
        private Label lblPeriodOfStay;
        private TextBox txtRate;
        private TextBox txtPeriodOfStay;
        private Label lblFinalRate;
        private TextBox txtFinalRate;
        private GroupBox groupBox3;
        private RadioButton rdTripleRoom;
        private RadioButton rdDoubleRoom;
        private RadioButton rdSingleRoom;
        private CheckBox ckWiFi;
        private CheckBox ckDinner;
        private CheckBox ckLunch;
        private CheckBox ckBreakfast;
        private CheckBox ckElectricRefueling;
        private Button btnCalculation;
    }
}