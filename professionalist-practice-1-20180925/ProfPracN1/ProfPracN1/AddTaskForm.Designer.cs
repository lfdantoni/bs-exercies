namespace ProfPracN1
{
    partial class AddTaskForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeliveryDaysControl = new ProfPracN1.UserControls.PositiveNumberControl();
            this.taskCode = new ProfPracN1.UserControls.PositiveNumberControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ProfPracN1.Properties.Resources.img_343953;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(158, 92);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(182, 20);
            this.dpDate.TabIndex = 4;
            this.dpDate.Value = new System.DateTime(2018, 10, 24, 22, 47, 32, 0);
            this.dpDate.ValueChanged += new System.EventHandler(this.updateDaliveryDate);
            // 
            // cmbDescription
            // 
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Items.AddRange(new object[] {
            "Pintar",
            "Lijar",
            "Rasquetar",
            "Enduir",
            "Limpiar"});
            this.cmbDescription.Location = new System.Drawing.Point(158, 66);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(182, 21);
            this.cmbDescription.TabIndex = 5;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Enabled = false;
            this.txtDeliveryDate.Location = new System.Drawing.Point(158, 151);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(182, 20);
            this.txtDeliveryDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo de Tarea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plazo de entrega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de entrega";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(729, 180);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(469, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Cargar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(469, 114);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(469, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeliveryDaysControl
            // 
            this.txtDeliveryDaysControl.Location = new System.Drawing.Point(158, 118);
            this.txtDeliveryDaysControl.MaxValue = 0;
            this.txtDeliveryDaysControl.MinValue = 0;
            this.txtDeliveryDaysControl.Name = "txtDeliveryDaysControl";
            this.txtDeliveryDaysControl.Required = true;
            this.txtDeliveryDaysControl.Size = new System.Drawing.Size(200, 27);
            this.txtDeliveryDaysControl.TabIndex = 7;
            this.txtDeliveryDaysControl.Value = 0;
            this.txtDeliveryDaysControl.ValueChanged = null;
            // 
            // taskCode
            // 
            this.taskCode.Location = new System.Drawing.Point(158, 33);
            this.taskCode.MaxValue = 0;
            this.taskCode.MinValue = 0;
            this.taskCode.Name = "taskCode";
            this.taskCode.Required = true;
            this.taskCode.Size = new System.Drawing.Size(200, 27);
            this.taskCode.TabIndex = 1;
            this.taskCode.Value = 0;
            this.taskCode.ValueChanged = null;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 356);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeliveryDaysControl);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.cmbDescription);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.taskCode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTaskForm_FormClosed);
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private UserControls.PositiveNumberControl taskCode;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.ComboBox cmbDescription;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private UserControls.PositiveNumberControl txtDeliveryDaysControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
    }
}