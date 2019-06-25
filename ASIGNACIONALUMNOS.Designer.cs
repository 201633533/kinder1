namespace Kinder
{
    partial class ASIGNACIONALUMNOS
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
            this.button4 = new System.Windows.Forms.Button();
            this.txtalumno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvalumno = new System.Windows.Forms.DataGridView();
            this.comboBoxgrupo = new System.Windows.Forms.ComboBox();
            this.comboBoxalumno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(363, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 25);
            this.button4.TabIndex = 23;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtalumno
            // 
            this.txtalumno.Location = new System.Drawing.Point(463, 59);
            this.txtalumno.Name = "txtalumno";
            this.txtalumno.Size = new System.Drawing.Size(178, 20);
            this.txtalumno.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "REGRESAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "ASIGNAR GRUPO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvalumno
            // 
            this.dgvalumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalumno.Location = new System.Drawing.Point(78, 226);
            this.dgvalumno.Name = "dgvalumno";
            this.dgvalumno.Size = new System.Drawing.Size(585, 178);
            this.dgvalumno.TabIndex = 18;
            // 
            // comboBoxgrupo
            // 
            this.comboBoxgrupo.FormattingEnabled = true;
            this.comboBoxgrupo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBoxgrupo.Location = new System.Drawing.Point(463, 139);
            this.comboBoxgrupo.Name = "comboBoxgrupo";
            this.comboBoxgrupo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxgrupo.TabIndex = 17;
            // 
            // comboBoxalumno
            // 
            this.comboBoxalumno.FormattingEnabled = true;
            this.comboBoxalumno.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxalumno.Location = new System.Drawing.Point(463, 99);
            this.comboBoxalumno.Name = "comboBoxalumno";
            this.comboBoxalumno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxalumno.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "GRUPO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "GRADO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ALUMNO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kinder.Properties.Resources.login_icon_png_27;
            this.pictureBox1.Location = new System.Drawing.Point(78, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 215);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ASIGNACIONALUMNOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtalumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvalumno);
            this.Controls.Add(this.comboBoxgrupo);
            this.Controls.Add(this.comboBoxalumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ASIGNACIONALUMNOS";
            this.Text = "ASIGNACIONALUMNOS";
            this.Load += new System.EventHandler(this.ASIGNACIONALUMNOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtalumno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvalumno;
        private System.Windows.Forms.ComboBox comboBoxgrupo;
        private System.Windows.Forms.ComboBox comboBoxalumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}