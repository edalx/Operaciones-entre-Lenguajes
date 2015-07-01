namespace Operaciones_entre_Lenguajes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alfabeto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lenguaje1 = new System.Windows.Forms.TextBox();
            this.union = new System.Windows.Forms.Button();
            this.interseccion = new System.Windows.Forms.Button();
            this.diferencia = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.aprobado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lenguaje2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones entre lenguajes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Σ=";
            // 
            // alfabeto
            // 
            this.alfabeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alfabeto.Location = new System.Drawing.Point(71, 81);
            this.alfabeto.Name = "alfabeto";
            this.alfabeto.Size = new System.Drawing.Size(645, 29);
            this.alfabeto.TabIndex = 2;
            this.alfabeto.TextChanged += new System.EventHandler(this.alfabeto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lenguaje 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lenguaje 2:";
            // 
            // lenguaje1
            // 
            this.lenguaje1.Enabled = false;
            this.lenguaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenguaje1.Location = new System.Drawing.Point(136, 126);
            this.lenguaje1.Name = "lenguaje1";
            this.lenguaje1.Size = new System.Drawing.Size(580, 29);
            this.lenguaje1.TabIndex = 5;
            this.lenguaje1.TextChanged += new System.EventHandler(this.lenguaje1_TextChanged);
            // 
            // union
            // 
            this.union.Enabled = false;
            this.union.Location = new System.Drawing.Point(38, 238);
            this.union.Name = "union";
            this.union.Size = new System.Drawing.Size(154, 41);
            this.union.TabIndex = 7;
            this.union.Text = "Unión";
            this.union.UseVisualStyleBackColor = true;
            this.union.Click += new System.EventHandler(this.union_Click);
            // 
            // interseccion
            // 
            this.interseccion.Enabled = false;
            this.interseccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.interseccion.Location = new System.Drawing.Point(38, 308);
            this.interseccion.Name = "interseccion";
            this.interseccion.Size = new System.Drawing.Size(154, 41);
            this.interseccion.TabIndex = 8;
            this.interseccion.Text = "Intersección";
            this.interseccion.UseVisualStyleBackColor = true;
            this.interseccion.Click += new System.EventHandler(this.interseccion_Click);
            // 
            // diferencia
            // 
            this.diferencia.Enabled = false;
            this.diferencia.Location = new System.Drawing.Point(38, 377);
            this.diferencia.Name = "diferencia";
            this.diferencia.Size = new System.Drawing.Size(154, 41);
            this.diferencia.TabIndex = 9;
            this.diferencia.Text = "Diferencia";
            this.diferencia.UseVisualStyleBackColor = true;
            this.diferencia.Click += new System.EventHandler(this.button3_Click);
            // 
            // resultado
            // 
            this.resultado.Enabled = false;
            this.resultado.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.Black;
            this.resultado.Location = new System.Drawing.Point(250, 264);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(466, 114);
            this.resultado.TabIndex = 10;
            // 
            // aprobado
            // 
            this.aprobado.AutoSize = true;
            this.aprobado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprobado.Location = new System.Drawing.Point(737, 77);
            this.aprobado.Name = "aprobado";
            this.aprobado.Size = new System.Drawing.Size(0, 31);
            this.aprobado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(722, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 13;
            // 
            // lenguaje2
            // 
            this.lenguaje2.Enabled = false;
            this.lenguaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenguaje2.Location = new System.Drawing.Point(136, 172);
            this.lenguaje2.Name = "lenguaje2";
            this.lenguaje2.Size = new System.Drawing.Size(580, 29);
            this.lenguaje2.TabIndex = 14;
            this.lenguaje2.TextChanged += new System.EventHandler(this.lenguaje2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 474);
            this.Controls.Add(this.lenguaje2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aprobado);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.diferencia);
            this.Controls.Add(this.interseccion);
            this.Controls.Add(this.union);
            this.Controls.Add(this.lenguaje1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alfabeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lenguajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alfabeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lenguaje1;
        private System.Windows.Forms.Button union;
        private System.Windows.Forms.Button interseccion;
        private System.Windows.Forms.Button diferencia;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label aprobado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lenguaje2;
    }
}

