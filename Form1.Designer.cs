namespace SAPB2
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
            this.btnSQL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHANA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(12, 64);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(132, 71);
            this.btnSQL.TabIndex = 0;
            this.btnSQL.Text = "SQL Server";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona el gestor de base de datos";
            // 
            // btnHANA
            // 
            this.btnHANA.Location = new System.Drawing.Point(176, 64);
            this.btnHANA.Name = "btnHANA";
            this.btnHANA.Size = new System.Drawing.Size(132, 71);
            this.btnHANA.TabIndex = 2;
            this.btnHANA.Text = "SAP HANA";
            this.btnHANA.UseVisualStyleBackColor = true;
            this.btnHANA.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 146);
            this.Controls.Add(this.btnHANA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSQL);
            this.Name = "Form1";
            this.Text = "Bases de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSQL;
        private Label label1;
        private Button btnHANA;
    }
}