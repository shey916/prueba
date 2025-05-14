namespace MIERCOLES30ABRIL25
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
            this.btncrearf = new System.Windows.Forms.Button();
            this.btncrearf2 = new System.Windows.Forms.Button();
            this.btnleer1 = new System.Windows.Forms.Button();
            this.btnleer2 = new System.Windows.Forms.Button();
            this.btnleer3 = new System.Windows.Forms.Button();
            this.btnleer4 = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncrearf
            // 
            this.btncrearf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearf.Location = new System.Drawing.Point(44, 53);
            this.btncrearf.Name = "btncrearf";
            this.btncrearf.Size = new System.Drawing.Size(118, 51);
            this.btncrearf.TabIndex = 0;
            this.btncrearf.Text = "Crear Fichero";
            this.btncrearf.UseVisualStyleBackColor = true;
            this.btncrearf.Click += new System.EventHandler(this.btncrearf_Click);
            // 
            // btncrearf2
            // 
            this.btncrearf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearf2.Location = new System.Drawing.Point(179, 53);
            this.btncrearf2.Name = "btncrearf2";
            this.btncrearf2.Size = new System.Drawing.Size(118, 51);
            this.btncrearf2.TabIndex = 1;
            this.btncrearf2.Text = "Forma 2 de Crear";
            this.btncrearf2.UseVisualStyleBackColor = true;
            this.btncrearf2.Click += new System.EventHandler(this.btncrearf2_Click);
            // 
            // btnleer1
            // 
            this.btnleer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleer1.Location = new System.Drawing.Point(318, 53);
            this.btnleer1.Name = "btnleer1";
            this.btnleer1.Size = new System.Drawing.Size(118, 51);
            this.btnleer1.TabIndex = 2;
            this.btnleer1.Text = "Leer Archivo";
            this.btnleer1.UseVisualStyleBackColor = true;
            this.btnleer1.Click += new System.EventHandler(this.btnleer1_Click);
            // 
            // btnleer2
            // 
            this.btnleer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleer2.Location = new System.Drawing.Point(458, 53);
            this.btnleer2.Name = "btnleer2";
            this.btnleer2.Size = new System.Drawing.Size(118, 51);
            this.btnleer2.TabIndex = 3;
            this.btnleer2.Text = "Leer Archivo";
            this.btnleer2.UseVisualStyleBackColor = true;
            this.btnleer2.Click += new System.EventHandler(this.btnleer2_Click);
            // 
            // btnleer3
            // 
            this.btnleer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleer3.Location = new System.Drawing.Point(597, 53);
            this.btnleer3.Name = "btnleer3";
            this.btnleer3.Size = new System.Drawing.Size(118, 51);
            this.btnleer3.TabIndex = 4;
            this.btnleer3.Text = "Leer Archivo";
            this.btnleer3.UseVisualStyleBackColor = true;
            this.btnleer3.Click += new System.EventHandler(this.btnleer3_Click);
            // 
            // btnleer4
            // 
            this.btnleer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleer4.Location = new System.Drawing.Point(44, 130);
            this.btnleer4.Name = "btnleer4";
            this.btnleer4.Size = new System.Drawing.Size(118, 51);
            this.btnleer4.TabIndex = 5;
            this.btnleer4.Text = "Leer Archivo";
            this.btnleer4.UseVisualStyleBackColor = true;
            this.btnleer4.Click += new System.EventHandler(this.btnleer4_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(179, 130);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(118, 51);
            this.btnmodificar.TabIndex = 6;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnleer4);
            this.Controls.Add(this.btnleer3);
            this.Controls.Add(this.btnleer2);
            this.Controls.Add(this.btnleer1);
            this.Controls.Add(this.btncrearf2);
            this.Controls.Add(this.btncrearf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncrearf;
        private System.Windows.Forms.Button btncrearf2;
        private System.Windows.Forms.Button btnleer1;
        private System.Windows.Forms.Button btnleer2;
        private System.Windows.Forms.Button btnleer3;
        private System.Windows.Forms.Button btnleer4;
        private System.Windows.Forms.Button btnmodificar;
    }
}

