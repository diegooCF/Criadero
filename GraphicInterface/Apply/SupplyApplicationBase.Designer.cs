namespace GraphicInterface.Apply
{
    partial class SupplyApplicationBase
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpApplication = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSupply = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 30);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Observaciones:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(124, 69);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(119, 81);
            this.txtComments.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha de aplicación:";
            // 
            // dtpApplication
            // 
            this.dtpApplication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpApplication.Location = new System.Drawing.Point(124, 43);
            this.dtpApplication.Name = "dtpApplication";
            this.dtpApplication.Size = new System.Drawing.Size(119, 20);
            this.dtpApplication.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Supply.ChangeThis:";
            // 
            // cboSupply
            // 
            this.cboSupply.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupply.FormattingEnabled = true;
            this.cboSupply.Location = new System.Drawing.Point(124, 16);
            this.cboSupply.Name = "cboSupply";
            this.cboSupply.Size = new System.Drawing.Size(118, 21);
            this.cboSupply.TabIndex = 15;
            // 
            // SupplyApplicationBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 200);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSupply);
            this.Name = "SupplyApplicationBase";
            this.Text = "Change this";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpApplication;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cboSupply;
    }
}