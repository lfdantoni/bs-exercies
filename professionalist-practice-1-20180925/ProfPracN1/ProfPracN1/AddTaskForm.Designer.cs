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
            this.txtDeliveryDays = new System.Windows.Forms.TextBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.taskCode = new ProfPracN1.UserControls.TaskCodeControl();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
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
            // txtDeliveryDays
            // 
            this.txtDeliveryDays.Location = new System.Drawing.Point(53, 139);
            this.txtDeliveryDays.Name = "txtDeliveryDays";
            this.txtDeliveryDays.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryDays.TabIndex = 3;
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(53, 97);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(200, 20);
            this.dpDate.TabIndex = 4;
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
            this.cmbDescription.Location = new System.Drawing.Point(53, 71);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(121, 21);
            this.cmbDescription.TabIndex = 5;
            // 
            // taskCode
            // 
            this.taskCode.Location = new System.Drawing.Point(53, 38);
            this.taskCode.Name = "taskCode";
            this.taskCode.Size = new System.Drawing.Size(132, 27);
            this.taskCode.TabIndex = 1;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Enabled = false;
            this.txtDeliveryDate.Location = new System.Drawing.Point(53, 165);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryDate.TabIndex = 6;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 356);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.cmbDescription);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.txtDeliveryDays);
            this.Controls.Add(this.taskCode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTaskForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private UserControls.TaskCodeControl taskCode;
        private System.Windows.Forms.TextBox txtDeliveryDays;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.ComboBox cmbDescription;
        private System.Windows.Forms.TextBox txtDeliveryDate;
    }
}