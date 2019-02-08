namespace EjemploRestful
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
            this.ComboProvincia = new System.Windows.Forms.ComboBox();
            this.ComboCanton = new System.Windows.Forms.ComboBox();
            this.ComboDistrito = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboProvincia
            // 
            this.ComboProvincia.FormattingEnabled = true;
            this.ComboProvincia.Location = new System.Drawing.Point(34, 89);
            this.ComboProvincia.Name = "ComboProvincia";
            this.ComboProvincia.Size = new System.Drawing.Size(242, 21);
            this.ComboProvincia.TabIndex = 0;
            this.ComboProvincia.SelectedIndexChanged += new System.EventHandler(this.ComboProvincia_SelectedIndexChanged);
            // 
            // ComboCanton
            // 
            this.ComboCanton.FormattingEnabled = true;
            this.ComboCanton.Location = new System.Drawing.Point(34, 142);
            this.ComboCanton.Name = "ComboCanton";
            this.ComboCanton.Size = new System.Drawing.Size(242, 21);
            this.ComboCanton.TabIndex = 1;
            this.ComboCanton.SelectedIndexChanged += new System.EventHandler(this.ComboCanton_SelectedIndexChanged);
            // 
            // ComboDistrito
            // 
            this.ComboDistrito.FormattingEnabled = true;
            this.ComboDistrito.Location = new System.Drawing.Point(34, 196);
            this.ComboDistrito.Name = "ComboDistrito";
            this.ComboDistrito.Size = new System.Drawing.Size(242, 21);
            this.ComboDistrito.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Canton";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Distrito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ejemplo de uso de RestFul";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 243);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboDistrito);
            this.Controls.Add(this.ComboCanton);
            this.Controls.Add(this.ComboProvincia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboProvincia;
        private System.Windows.Forms.ComboBox ComboCanton;
        private System.Windows.Forms.ComboBox ComboDistrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

