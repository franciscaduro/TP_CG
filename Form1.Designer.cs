namespace TrabalhoCG_Prop3
{
    partial class Form1
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
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.trbRotY = new System.Windows.Forms.TrackBar();
            this.trbEscala = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.btnCubo = new System.Windows.Forms.Button();
            this.btnCone = new System.Windows.Forms.Button();
            this.btnCilindro = new System.Windows.Forms.Button();
            this.btnEsfera = new System.Windows.Forms.Button();
            this.rbPerspetiva = new System.Windows.Forms.RadioButton();
            this.rbParalela = new System.Windows.Forms.RadioButton();
            this.lblArestas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pctBox.Location = new System.Drawing.Point(21, 28);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(614, 377);
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            this.pctBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pctBox_Paint);
            // 
            // trbRotY
            // 
            this.trbRotY.Location = new System.Drawing.Point(641, 179);
            this.trbRotY.Maximum = 180;
            this.trbRotY.Minimum = -180;
            this.trbRotY.Name = "trbRotY";
            this.trbRotY.Size = new System.Drawing.Size(137, 56);
            this.trbRotY.TabIndex = 1;
            this.trbRotY.Scroll += new System.EventHandler(this.trbRotY_Scroll);
            // 
            // trbEscala
            // 
            this.trbEscala.Location = new System.Drawing.Point(641, 241);
            this.trbEscala.Maximum = 50;
            this.trbEscala.Minimum = 1;
            this.trbEscala.Name = "trbEscala";
            this.trbEscala.Size = new System.Drawing.Size(137, 56);
            this.trbEscala.TabIndex = 2;
            this.trbEscala.Value = 1;
            this.trbEscala.Scroll += new System.EventHandler(this.trbEscala_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(641, 313);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(137, 56);
            this.trackBar3.TabIndex = 3;
            // 
            // btnCubo
            // 
            this.btnCubo.Location = new System.Drawing.Point(678, 28);
            this.btnCubo.Name = "btnCubo";
            this.btnCubo.Size = new System.Drawing.Size(75, 23);
            this.btnCubo.TabIndex = 4;
            this.btnCubo.Text = "Cubo";
            this.btnCubo.UseVisualStyleBackColor = true;
            this.btnCubo.Click += new System.EventHandler(this.btnCubo_Click);
            // 
            // btnCone
            // 
            this.btnCone.Location = new System.Drawing.Point(678, 65);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(75, 23);
            this.btnCone.TabIndex = 5;
            this.btnCone.Text = "Cone";
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // btnCilindro
            // 
            this.btnCilindro.Location = new System.Drawing.Point(678, 103);
            this.btnCilindro.Name = "btnCilindro";
            this.btnCilindro.Size = new System.Drawing.Size(75, 23);
            this.btnCilindro.TabIndex = 6;
            this.btnCilindro.Text = "Cilindro";
            this.btnCilindro.UseVisualStyleBackColor = true;
            this.btnCilindro.Click += new System.EventHandler(this.btnCilindro_Click);
            // 
            // btnEsfera
            // 
            this.btnEsfera.Location = new System.Drawing.Point(678, 141);
            this.btnEsfera.Name = "btnEsfera";
            this.btnEsfera.Size = new System.Drawing.Size(75, 23);
            this.btnEsfera.TabIndex = 7;
            this.btnEsfera.Text = "Esfera";
            this.btnEsfera.UseVisualStyleBackColor = true;
            this.btnEsfera.Click += new System.EventHandler(this.btnEsfera_Click);
            // 
            // rbPerspetiva
            // 
            this.rbPerspetiva.AutoSize = true;
            this.rbPerspetiva.Checked = true;
            this.rbPerspetiva.Location = new System.Drawing.Point(657, 360);
            this.rbPerspetiva.Name = "rbPerspetiva";
            this.rbPerspetiva.Size = new System.Drawing.Size(86, 20);
            this.rbPerspetiva.TabIndex = 8;
            this.rbPerspetiva.TabStop = true;
            this.rbPerspetiva.Text = "Perpetiva";
            this.rbPerspetiva.UseVisualStyleBackColor = true;
            this.rbPerspetiva.CheckedChanged += new System.EventHandler(this.rbPerspetiva_CheckedChanged);
            // 
            // rbParalela
            // 
            this.rbParalela.AutoSize = true;
            this.rbParalela.Location = new System.Drawing.Point(657, 387);
            this.rbParalela.Name = "rbParalela";
            this.rbParalela.Size = new System.Drawing.Size(79, 20);
            this.rbParalela.TabIndex = 9;
            this.rbParalela.Text = "Paralela";
            this.rbParalela.UseVisualStyleBackColor = true;
            this.rbParalela.CheckedChanged += new System.EventHandler(this.rbPerspetiva_CheckedChanged);
            // 
            // lblArestas
            // 
            this.lblArestas.AutoSize = true;
            this.lblArestas.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArestas.Location = new System.Drawing.Point(554, 412);
            this.lblArestas.Name = "lblArestas";
            this.lblArestas.Size = new System.Drawing.Size(70, 14);
            this.lblArestas.TabIndex = 10;
            this.lblArestas.Text = "Arestas: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 445);
            this.Controls.Add(this.lblArestas);
            this.Controls.Add(this.rbParalela);
            this.Controls.Add(this.rbPerspetiva);
            this.Controls.Add(this.btnEsfera);
            this.Controls.Add(this.btnCilindro);
            this.Controls.Add(this.btnCone);
            this.Controls.Add(this.btnCubo);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trbEscala);
            this.Controls.Add(this.trbRotY);
            this.Controls.Add(this.pctBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.TrackBar trbRotY;
        private System.Windows.Forms.TrackBar trbEscala;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Button btnCubo;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.Button btnCilindro;
        private System.Windows.Forms.Button btnEsfera;
        private System.Windows.Forms.RadioButton rbPerspetiva;
        private System.Windows.Forms.RadioButton rbParalela;
        private System.Windows.Forms.Label lblArestas;
    }
}