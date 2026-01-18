namespace TrabalhoCG_Prop3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.trbRotY = new System.Windows.Forms.TrackBar();
            this.trbEscala = new System.Windows.Forms.TrackBar();
            this.btnCubo = new System.Windows.Forms.Button();
            this.btnCone = new System.Windows.Forms.Button();
            this.btnCilindro = new System.Windows.Forms.Button();
            this.btnEsfera = new System.Windows.Forms.Button();
            this.rbPerspetiva = new System.Windows.Forms.RadioButton();
            this.rbParalela = new System.Windows.Forms.RadioButton();
            this.lblArestas = new System.Windows.Forms.Label();
            this.btnCarregarModelo = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscala)).BeginInit();
            this.SuspendLayout();

            // pctBox
            this.pctBox.BackColor = System.Drawing.Color.White;
            this.pctBox.Location = new System.Drawing.Point(20, 20);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(600, 400);
            this.pctBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pctBox_Paint);

            // trbRotY
            this.trbRotY.Location = new System.Drawing.Point(640, 20);
            this.trbRotY.Minimum = -180;
            this.trbRotY.Maximum = 180;
            this.trbRotY.Scroll += new System.EventHandler(this.trbRotY_Scroll);

            // trbEscala
            this.trbEscala.Location = new System.Drawing.Point(640, 60);
            this.trbEscala.Minimum = 1;
            this.trbEscala.Maximum = 50;
            this.trbEscala.Value = 10;
            this.trbEscala.Scroll += new System.EventHandler(this.trbEscala_Scroll);

            this.trbRaio = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbRaio)).BeginInit();

            // trbRaio
            this.trbRaio.Location = new System.Drawing.Point(640, 350);
            this.trbRaio.Minimum = 1;
            this.trbRaio.Maximum = 50;
            this.trbRaio.Value = 10;
            this.trbRaio.Scroll += new System.EventHandler(this.trbRaio_Scroll);

            this.Controls.Add(this.trbRaio);


            // Botões de modelos
            this.btnCubo.Location = new System.Drawing.Point(640, 100);
            this.btnCubo.Text = "Cubo";
            this.btnCubo.Click += new System.EventHandler(this.btnCubo_Click);

            this.btnCone.Location = new System.Drawing.Point(640, 130);
            this.btnCone.Text = "Cone";
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);

            this.btnCilindro.Location = new System.Drawing.Point(640, 160);
            this.btnCilindro.Text = "Cilindro";
            this.btnCilindro.Click += new System.EventHandler(this.btnCilindro_Click);

            this.btnEsfera.Location = new System.Drawing.Point(640, 190);
            this.btnEsfera.Text = "Esfera";
            this.btnEsfera.Click += new System.EventHandler(this.btnEsfera_Click);

            // RadioButtons de projeção
            this.rbPerspetiva.Location = new System.Drawing.Point(640, 230);
            this.rbPerspetiva.Text = "Perspetiva";
            this.rbPerspetiva.Checked = true;
            this.rbPerspetiva.CheckedChanged += new System.EventHandler(this.rbPerspetiva_CheckedChanged);

            this.rbParalela.Location = new System.Drawing.Point(640, 260);
            this.rbParalela.Text = "Paralela";
            this.rbParalela.CheckedChanged += new System.EventHandler(this.rbPerspetiva_CheckedChanged);

            // Label de arestas
            this.lblArestas.Location = new System.Drawing.Point(640, 290);
            this.lblArestas.Text = "Arestas: 0";

            // Botão carregar modelo
            this.btnCarregarModelo.Location = new System.Drawing.Point(640, 320);
            this.btnCarregarModelo.Text = "Carregar";
            this.btnCarregarModelo.Click += new System.EventHandler(this.btnCarregarModelo_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.trbRotY);
            this.Controls.Add(this.trbEscala);
            this.Controls.Add(this.btnCubo);
            this.Controls.Add(this.btnCone);
            this.Controls.Add(this.btnCilindro);
            this.Controls.Add(this.btnEsfera);
            this.Controls.Add(this.rbPerspetiva);
            this.Controls.Add(this.rbParalela);
            this.Controls.Add(this.lblArestas);
            this.Controls.Add(this.btnCarregarModelo);
            this.Name = "Form1";
            this.Text = "Trabalho CG";

            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.TrackBar trbRotY;
        private System.Windows.Forms.TrackBar trbEscala;
        private System.Windows.Forms.Button btnCubo;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.Button btnCilindro;
        private System.Windows.Forms.Button btnEsfera;
        private System.Windows.Forms.RadioButton rbPerspetiva;
        private System.Windows.Forms.RadioButton rbParalela;
        private System.Windows.Forms.Label lblArestas;
        private System.Windows.Forms.Button btnCarregarModelo;
        private System.Windows.Forms.TrackBar trbRaio;

    }
}