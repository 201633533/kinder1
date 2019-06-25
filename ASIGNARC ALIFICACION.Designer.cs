namespace Kinder
{
    partial class ASIGNAR_CALIFICACION
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcalificacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewCALI = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxalumno = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxmatricula = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCALI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALUMNO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CALIFICACION:";
            // 
            // textBoxcalificacion
            // 
            this.textBoxcalificacion.Location = new System.Drawing.Point(192, 129);
            this.textBoxcalificacion.Name = "textBoxcalificacion";
            this.textBoxcalificacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxcalificacion.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(79, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "ASIGNAR 1er BIMESTRE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(295, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "ASIGNAR 2do BIMESTRE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(528, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "ASIGNAR 3er BIMESTRE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCALI
            // 
            this.dataGridViewCALI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCALI.Location = new System.Drawing.Point(93, 260);
            this.dataGridViewCALI.Name = "dataGridViewCALI";
            this.dataGridViewCALI.Size = new System.Drawing.Size(550, 178);
            this.dataGridViewCALI.TabIndex = 7;
            this.dataGridViewCALI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCALI_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(662, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 37);
            this.button4.TabIndex = 8;
            this.button4.Text = "MODIFICAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(662, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 33);
            this.button5.TabIndex = 9;
            this.button5.Text = "REGRESAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxalumno
            // 
            this.textBoxalumno.Location = new System.Drawing.Point(192, 86);
            this.textBoxalumno.Name = "textBoxalumno";
            this.textBoxalumno.Size = new System.Drawing.Size(234, 20);
            this.textBoxalumno.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(324, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 42);
            this.button6.TabIndex = 11;
            this.button6.Text = "BUSCAR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxmatricula
            // 
            this.textBoxmatricula.Location = new System.Drawing.Point(192, 39);
            this.textBoxmatricula.Name = "textBoxmatricula";
            this.textBoxmatricula.Size = new System.Drawing.Size(100, 20);
            this.textBoxmatricula.TabIndex = 12;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(102, 46);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(72, 13);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "MATRICULA:";
            // 
            // ASIGNAR_CALIFICACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.textBoxmatricula);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBoxalumno);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridViewCALI);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxcalificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ASIGNAR_CALIFICACION";
            this.Text = "ASIGNAR_CALIFICACION";
            this.Load += new System.EventHandler(this.ASIGNAR_CALIFICACION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCALI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxcalificacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewCALI;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxalumno;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxmatricula;
        private System.Windows.Forms.Label lbl;
    }
}