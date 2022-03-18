namespace TareaEjercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsuariotextBox1 = new System.Windows.Forms.TextBox();
            this.ClavetextBox2 = new System.Windows.Forms.TextBox();
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsuariotextBox1
            // 
            this.UsuariotextBox1.Location = new System.Drawing.Point(162, 37);
            this.UsuariotextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.UsuariotextBox1.Name = "UsuariotextBox1";
            this.UsuariotextBox1.Size = new System.Drawing.Size(213, 22);
            this.UsuariotextBox1.TabIndex = 0;
            // 
            // ClavetextBox2
            // 
            this.ClavetextBox2.Location = new System.Drawing.Point(162, 80);
            this.ClavetextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ClavetextBox2.Name = "ClavetextBox2";
            this.ClavetextBox2.PasswordChar = '*';
            this.ClavetextBox2.Size = new System.Drawing.Size(213, 22);
            this.ClavetextBox2.TabIndex = 1;
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.Location = new System.Drawing.Point(162, 110);
            this.Aceptarbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.Aceptarbutton1.Name = "Aceptarbutton1";
            this.Aceptarbutton1.Size = new System.Drawing.Size(99, 38);
            this.Aceptarbutton1.TabIndex = 2;
            this.Aceptarbutton1.Text = "Aceptar";
            this.Aceptarbutton1.UseVisualStyleBackColor = true;
            this.Aceptarbutton1.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            // 
            // Cancelarbutton2
            // 
            this.Cancelarbutton2.Location = new System.Drawing.Point(276, 110);
            this.Cancelarbutton2.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelarbutton2.Name = "Cancelarbutton2";
            this.Cancelarbutton2.Size = new System.Drawing.Size(99, 38);
            this.Cancelarbutton2.TabIndex = 3;
            this.Cancelarbutton2.Text = "Cancelar";
            this.Cancelarbutton2.UseVisualStyleBackColor = true;
            this.Cancelarbutton2.Click += new System.EventHandler(this.Cancelarbutton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clave:";
            // 
            // Form1
            // 
            this.AcceptButton = this.Aceptarbutton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton2;
            this.ClientSize = new System.Drawing.Size(487, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbutton2);
            this.Controls.Add(this.Aceptarbutton1);
            this.Controls.Add(this.ClavetextBox2);
            this.Controls.Add(this.UsuariotextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuariotextBox1;
        private System.Windows.Forms.TextBox ClavetextBox2;
        private System.Windows.Forms.Button Aceptarbutton1;
        private System.Windows.Forms.Button Cancelarbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

