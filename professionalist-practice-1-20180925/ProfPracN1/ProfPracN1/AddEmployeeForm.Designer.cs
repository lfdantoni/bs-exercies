namespace ProfPracN1
{
    partial class AddEmployeeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbJobPosition = new System.Windows.Forms.ComboBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtSalary1 = new System.Windows.Forms.TextBox();
            this.txtSalary2 = new System.Windows.Forms.TextBox();
            this.txtSalary3 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPaintersCount = new System.Windows.Forms.TextBox();
            this.txtGenStuffCount = new System.Windows.Forms.TextBox();
            this.txtCleaningStuffCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbJobPosition);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.txtSalary1);
            this.groupBox1.Controls.Add(this.txtSalary2);
            this.groupBox1.Controls.Add(this.txtSalary3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de datos";
            // 
            // cmbJobPosition
            // 
            this.cmbJobPosition.FormattingEnabled = true;
            this.cmbJobPosition.Location = new System.Drawing.Point(69, 98);
            this.cmbJobPosition.Name = "cmbJobPosition";
            this.cmbJobPosition.Size = new System.Drawing.Size(173, 21);
            this.cmbJobPosition.TabIndex = 2;
            this.cmbJobPosition.SelectedValueChanged += new System.EventHandler(this.cmbJobPosition_SelectedValueChanged);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(69, 60);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(173, 20);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
            // 
            // txtSalary1
            // 
            this.txtSalary1.Location = new System.Drawing.Point(69, 138);
            this.txtSalary1.Name = "txtSalary1";
            this.txtSalary1.Size = new System.Drawing.Size(173, 20);
            this.txtSalary1.TabIndex = 3;
            this.txtSalary1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary1_KeyPress);
            this.txtSalary1.Validated += new System.EventHandler(this.txtSalary1_Validated);
            // 
            // txtSalary2
            // 
            this.txtSalary2.Location = new System.Drawing.Point(69, 171);
            this.txtSalary2.Name = "txtSalary2";
            this.txtSalary2.Size = new System.Drawing.Size(173, 20);
            this.txtSalary2.TabIndex = 4;
            this.txtSalary2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary2_KeyPress);
            this.txtSalary2.Validated += new System.EventHandler(this.txtSalary2_Validated);
            // 
            // txtSalary3
            // 
            this.txtSalary3.Location = new System.Drawing.Point(69, 210);
            this.txtSalary3.Name = "txtSalary3";
            this.txtSalary3.Size = new System.Drawing.Size(173, 20);
            this.txtSalary3.TabIndex = 5;
            this.txtSalary3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary3_KeyPress);
            this.txtSalary3.Validated += new System.EventHandler(this.txtSalary3_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sueldo 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAverage);
            this.groupBox2.Controls.Add(this.txtSum);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(342, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida de datos";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(142, 56);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(156, 20);
            this.txtAverage.TabIndex = 15;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(142, 21);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(156, 20);
            this.txtSum.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPaintersCount);
            this.groupBox4.Controls.Add(this.txtGenStuffCount);
            this.groupBox4.Controls.Add(this.txtCleaningStuffCount);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(0, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 159);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Empleados";
            // 
            // txtPaintersCount
            // 
            this.txtPaintersCount.Location = new System.Drawing.Point(142, 36);
            this.txtPaintersCount.Name = "txtPaintersCount";
            this.txtPaintersCount.ReadOnly = true;
            this.txtPaintersCount.Size = new System.Drawing.Size(156, 20);
            this.txtPaintersCount.TabIndex = 17;
            // 
            // txtGenStuffCount
            // 
            this.txtGenStuffCount.Location = new System.Drawing.Point(142, 108);
            this.txtGenStuffCount.Name = "txtGenStuffCount";
            this.txtGenStuffCount.ReadOnly = true;
            this.txtGenStuffCount.Size = new System.Drawing.Size(156, 20);
            this.txtGenStuffCount.TabIndex = 16;
            // 
            // txtCleaningStuffCount
            // 
            this.txtCleaningStuffCount.Location = new System.Drawing.Point(142, 69);
            this.txtCleaningStuffCount.Name = "txtCleaningStuffCount";
            this.txtCleaningStuffCount.ReadOnly = true;
            this.txtCleaningStuffCount.Size = new System.Drawing.Size(156, 20);
            this.txtCleaningStuffCount.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Operarios de Limpieza";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Operarios Generales";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pintores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Promedio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Suma";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClean);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnShow);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(124, 28);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(221, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(22, 28);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 363);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEmployeeForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEmployeeForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtSalary1;
        private System.Windows.Forms.TextBox txtSalary2;
        private System.Windows.Forms.TextBox txtSalary3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbJobPosition;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPaintersCount;
        private System.Windows.Forms.TextBox txtGenStuffCount;
        private System.Windows.Forms.TextBox txtCleaningStuffCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

