namespace VehicleRent
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.btn_VehicleDisplay = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.cb_Vehicle = new System.Windows.Forms.ComboBox();
            this.lbl_KmTravelled = new System.Windows.Forms.Label();
            this.gb_NewJourney = new System.Windows.Forms.GroupBox();
            this.btn_NewJourney = new System.Windows.Forms.Button();
            this.txt_KmTravelled = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gb_Vehicle = new System.Windows.Forms.GroupBox();
            this.gb_NewJourney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gb_Vehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_VehicleDisplay
            // 
            this.btn_VehicleDisplay.Location = new System.Drawing.Point(406, 46);
            this.btn_VehicleDisplay.Name = "btn_VehicleDisplay";
            this.btn_VehicleDisplay.Size = new System.Drawing.Size(150, 30);
            this.btn_VehicleDisplay.TabIndex = 0;
            this.btn_VehicleDisplay.Text = "Print Vehicle To Screen";
            this.btn_VehicleDisplay.UseVisualStyleBackColor = true;
            this.btn_VehicleDisplay.Click += new System.EventHandler(this.btn_VehicleDisplay_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(481, 12);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 4;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // cb_Vehicle
            // 
            this.cb_Vehicle.FormattingEnabled = true;
            this.cb_Vehicle.Items.AddRange(new object[] {
            "Vehicle 1",
            "Vehicle 2",
            "Vehicle 3"});
            this.cb_Vehicle.Location = new System.Drawing.Point(56, 34);
            this.cb_Vehicle.Name = "cb_Vehicle";
            this.cb_Vehicle.Size = new System.Drawing.Size(150, 21);
            this.cb_Vehicle.TabIndex = 5;
            // 
            // lbl_KmTravelled
            // 
            this.lbl_KmTravelled.AutoSize = true;
            this.lbl_KmTravelled.Location = new System.Drawing.Point(16, 38);
            this.lbl_KmTravelled.Name = "lbl_KmTravelled";
            this.lbl_KmTravelled.Size = new System.Drawing.Size(105, 13);
            this.lbl_KmTravelled.TabIndex = 6;
            this.lbl_KmTravelled.Text = "Kilometres Travelled:";
            // 
            // gb_NewJourney
            // 
            this.gb_NewJourney.Controls.Add(this.btn_NewJourney);
            this.gb_NewJourney.Controls.Add(this.txt_KmTravelled);
            this.gb_NewJourney.Controls.Add(this.lbl_KmTravelled);
            this.gb_NewJourney.Location = new System.Drawing.Point(6, 73);
            this.gb_NewJourney.Name = "gb_NewJourney";
            this.gb_NewJourney.Size = new System.Drawing.Size(248, 145);
            this.gb_NewJourney.TabIndex = 7;
            this.gb_NewJourney.TabStop = false;
            this.gb_NewJourney.Text = "New Journey:";
            // 
            // btn_NewJourney
            // 
            this.btn_NewJourney.Location = new System.Drawing.Point(50, 82);
            this.btn_NewJourney.Name = "btn_NewJourney";
            this.btn_NewJourney.Size = new System.Drawing.Size(150, 30);
            this.btn_NewJourney.TabIndex = 9;
            this.btn_NewJourney.Text = "New Journey";
            this.btn_NewJourney.UseVisualStyleBackColor = true;
            this.btn_NewJourney.Click += new System.EventHandler(this.btn_NewJourney_Click);
            // 
            // txt_KmTravelled
            // 
            this.txt_KmTravelled.Location = new System.Drawing.Point(143, 35);
            this.txt_KmTravelled.Name = "txt_KmTravelled";
            this.txt_KmTravelled.Size = new System.Drawing.Size(85, 20);
            this.txt_KmTravelled.TabIndex = 8;
            // 
            // gb_Vehicle
            // 
            this.gb_Vehicle.Controls.Add(this.cb_Vehicle);
            this.gb_Vehicle.Controls.Add(this.gb_NewJourney);
            this.gb_Vehicle.Location = new System.Drawing.Point(12, 12);
            this.gb_Vehicle.Name = "gb_Vehicle";
            this.gb_Vehicle.Size = new System.Drawing.Size(263, 346);
            this.gb_Vehicle.TabIndex = 9;
            this.gb_Vehicle.TabStop = false;
            this.gb_Vehicle.Text = "Select Vehicle:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 427);
            this.Controls.Add(this.gb_Vehicle);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_VehicleDisplay);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.gb_NewJourney.ResumeLayout(false);
            this.gb_NewJourney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gb_Vehicle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VehicleDisplay;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.ComboBox cb_Vehicle;
        private System.Windows.Forms.Label lbl_KmTravelled;
        private System.Windows.Forms.GroupBox gb_NewJourney;
        private System.Windows.Forms.TextBox txt_KmTravelled;
        private System.Windows.Forms.Button btn_NewJourney;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox gb_Vehicle;
    }
}

