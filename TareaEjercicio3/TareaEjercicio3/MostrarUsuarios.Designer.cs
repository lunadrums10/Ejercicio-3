namespace TareaEjercicio3
{
    partial class MostrarUsuarios
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
            this.MostrarUsuariodataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Cerrarbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarUsuariodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarUsuariodataGridView1
            // 
            this.MostrarUsuariodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostrarUsuariodataGridView1.Location = new System.Drawing.Point(44, 78);
            this.MostrarUsuariodataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarUsuariodataGridView1.Name = "MostrarUsuariodataGridView1";
            this.MostrarUsuariodataGridView1.Size = new System.Drawing.Size(728, 119);
            this.MostrarUsuariodataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de usuarios de la base de datos";
            // 
            // Cerrarbutton1
            // 
            this.Cerrarbutton1.Location = new System.Drawing.Point(44, 209);
            this.Cerrarbutton1.Name = "Cerrarbutton1";
            this.Cerrarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Cerrarbutton1.TabIndex = 2;
            this.Cerrarbutton1.Text = "Cerrar";
            this.Cerrarbutton1.UseVisualStyleBackColor = true;
            this.Cerrarbutton1.Click += new System.EventHandler(this.Cerrarbutton1_Click);
            // 
            // MostrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 244);
            this.Controls.Add(this.Cerrarbutton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MostrarUsuariodataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MostrarUsuarios";
            this.Text = "MostrarUsuarios";
            this.Load += new System.EventHandler(this.MostrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarUsuariodataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MostrarUsuariodataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cerrarbutton1;
    }
}