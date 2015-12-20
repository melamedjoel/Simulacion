namespace Simulacion
{
    partial class Simulacion
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
            this.lblCantEmp = new System.Windows.Forms.Label();
            this.txtCantEmpl = new System.Windows.Forms.TextBox();
            this.txtCantEmplNuevos = new System.Windows.Forms.TextBox();
            this.lblCantEmplNuevos = new System.Windows.Forms.Label();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblPPSInfo = new System.Windows.Forms.Label();
            this.lblPECInfo = new System.Windows.Forms.Label();
            this.lblPArrInfo = new System.Windows.Forms.Label();
            this.lblPTO = new System.Windows.Forms.Label();
            this.lblPArr = new System.Windows.Forms.Label();
            this.lblPEC = new System.Windows.Forms.Label();
            this.lblPPS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantCli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCantEmp
            // 
            this.lblCantEmp.AutoSize = true;
            this.lblCantEmp.Location = new System.Drawing.Point(54, 68);
            this.lblCantEmp.Name = "lblCantEmp";
            this.lblCantEmp.Size = new System.Drawing.Size(103, 13);
            this.lblCantEmp.TabIndex = 0;
            this.lblCantEmp.Text = "Cantidad empleados";
            this.lblCantEmp.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCantEmpl
            // 
            this.txtCantEmpl.Location = new System.Drawing.Point(205, 65);
            this.txtCantEmpl.Name = "txtCantEmpl";
            this.txtCantEmpl.Size = new System.Drawing.Size(100, 20);
            this.txtCantEmpl.TabIndex = 1;
            // 
            // txtCantEmplNuevos
            // 
            this.txtCantEmplNuevos.Location = new System.Drawing.Point(205, 103);
            this.txtCantEmplNuevos.Name = "txtCantEmplNuevos";
            this.txtCantEmplNuevos.Size = new System.Drawing.Size(100, 20);
            this.txtCantEmplNuevos.TabIndex = 3;
            // 
            // lblCantEmplNuevos
            // 
            this.lblCantEmplNuevos.AutoSize = true;
            this.lblCantEmplNuevos.Location = new System.Drawing.Point(54, 106);
            this.lblCantEmplNuevos.Name = "lblCantEmplNuevos";
            this.lblCantEmplNuevos.Size = new System.Drawing.Size(141, 13);
            this.lblCantEmplNuevos.TabIndex = 2;
            this.lblCantEmplNuevos.Text = "Cantidad empleados nuevos";
            this.lblCantEmplNuevos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Items.AddRange(new object[] {
            "Turno Mañana",
            "Turno Tarde"});
            this.cmbTurnos.Location = new System.Drawing.Point(362, 85);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(195, 21);
            this.cmbTurnos.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(225, 159);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(173, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Correr simulacion";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblPPSInfo
            // 
            this.lblPPSInfo.AutoSize = true;
            this.lblPPSInfo.Location = new System.Drawing.Point(54, 286);
            this.lblPPSInfo.Name = "lblPPSInfo";
            this.lblPPSInfo.Size = new System.Drawing.Size(28, 13);
            this.lblPPSInfo.TabIndex = 6;
            this.lblPPSInfo.Text = "PPS";
            this.lblPPSInfo.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblPECInfo
            // 
            this.lblPECInfo.AutoSize = true;
            this.lblPECInfo.Location = new System.Drawing.Point(54, 316);
            this.lblPECInfo.Name = "lblPECInfo";
            this.lblPECInfo.Size = new System.Drawing.Size(28, 13);
            this.lblPECInfo.TabIndex = 7;
            this.lblPECInfo.Text = "PEC";
            // 
            // lblPArrInfo
            // 
            this.lblPArrInfo.AutoSize = true;
            this.lblPArrInfo.Location = new System.Drawing.Point(54, 345);
            this.lblPArrInfo.Name = "lblPArrInfo";
            this.lblPArrInfo.Size = new System.Drawing.Size(27, 13);
            this.lblPArrInfo.TabIndex = 8;
            this.lblPArrInfo.Text = "PArr";
            // 
            // lblPTO
            // 
            this.lblPTO.Location = new System.Drawing.Point(390, 286);
            this.lblPTO.Name = "lblPTO";
            this.lblPTO.Size = new System.Drawing.Size(167, 86);
            this.lblPTO.TabIndex = 9;
            // 
            // lblPArr
            // 
            this.lblPArr.AutoSize = true;
            this.lblPArr.Location = new System.Drawing.Point(129, 345);
            this.lblPArr.Name = "lblPArr";
            this.lblPArr.Size = new System.Drawing.Size(27, 13);
            this.lblPArr.TabIndex = 12;
            this.lblPArr.Text = "PArr";
            // 
            // lblPEC
            // 
            this.lblPEC.AutoSize = true;
            this.lblPEC.Location = new System.Drawing.Point(129, 316);
            this.lblPEC.Name = "lblPEC";
            this.lblPEC.Size = new System.Drawing.Size(28, 13);
            this.lblPEC.TabIndex = 11;
            this.lblPEC.Text = "PEC";
            // 
            // lblPPS
            // 
            this.lblPPS.AutoSize = true;
            this.lblPPS.Location = new System.Drawing.Point(129, 286);
            this.lblPPS.Name = "lblPPS";
            this.lblPPS.Size = new System.Drawing.Size(28, 13);
            this.lblPPS.TabIndex = 10;
            this.lblPPS.Text = "PPS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "PTO(i)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad de clientes";
            // 
            // lblCantCli
            // 
            this.lblCantCli.AutoSize = true;
            this.lblCantCli.Location = new System.Drawing.Point(454, 372);
            this.lblCantCli.Name = "lblCantCli";
            this.lblCantCli.Size = new System.Drawing.Size(103, 13);
            this.lblCantCli.TabIndex = 15;
            this.lblCantCli.Text = "Cantidad de clientes";
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 412);
            this.Controls.Add(this.lblCantCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPArr);
            this.Controls.Add(this.lblPEC);
            this.Controls.Add(this.lblPPS);
            this.Controls.Add(this.lblPTO);
            this.Controls.Add(this.lblPArrInfo);
            this.Controls.Add(this.lblPECInfo);
            this.Controls.Add(this.lblPPSInfo);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cmbTurnos);
            this.Controls.Add(this.txtCantEmplNuevos);
            this.Controls.Add(this.lblCantEmplNuevos);
            this.Controls.Add(this.txtCantEmpl);
            this.Controls.Add(this.lblCantEmp);
            this.Name = "Simulacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantEmp;
        private System.Windows.Forms.TextBox txtCantEmpl;
        private System.Windows.Forms.TextBox txtCantEmplNuevos;
        private System.Windows.Forms.Label lblCantEmplNuevos;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblPPSInfo;
        private System.Windows.Forms.Label lblPECInfo;
        private System.Windows.Forms.Label lblPArrInfo;
        private System.Windows.Forms.Label lblPTO;
        private System.Windows.Forms.Label lblPArr;
        private System.Windows.Forms.Label lblPEC;
        private System.Windows.Forms.Label lblPPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantCli;

    }
}

