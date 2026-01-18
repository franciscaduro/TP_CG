using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO; 

namespace TrabalhoCG_Prop3
{
    public partial class Form1 : Form
    {
        Modelo3D modeloAtual;
        float anguloY = 0;
        float escala = 80.0f;
        float distCamara = 500f;
        float raioAtual = 1.0f;
        float alturaAtual = 2.0f;



        public Form1()
        {
            InitializeComponent();
            ConfigurarControlos();

            // Iniciar com cubo
            modeloAtual = Modelo3D.CriarCubo();
            AtualizarInfo();
        }

        private void ConfigurarControlos()
        {
            if (trbRotY != null) { trbRotY.Minimum = -180; trbRotY.Maximum = 180; trbRotY.Value = 0; }
            if (trbEscala != null) { trbEscala.Minimum = 10; trbEscala.Maximum = 300; trbEscala.Value = 100; }
        }

        // --- MOTOR GRÁFICO ---
        private void pctBox_Paint(object sender, PaintEventArgs e)
        {
            if (modeloAtual == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int cx = pctBox.Width / 2;
            int cy = pctBox.Height / 2;

            // Matrizes
            Matriz3D mEscala = Matriz3D.Escala(escala, escala, escala);
            Matriz3D mRotY = Matriz3D.RotacaoY(anguloY);
            Matriz3D mTransf = mRotY * mEscala; // Roda e depois Escala

            Matriz3D mProj;
            if (rbPerspetiva.Checked)
                mProj = Matriz3D.ProjPerspetiva(distCamara);
            else
                mProj = new Matriz3D(); // Paralela

            Pen caneta = new Pen(Color.Black, 1.5f);

            // Desenhar Faces
            foreach (int[] face in modeloAtual.Faces)
            {
                List<PointF> pts = new List<PointF>();
                foreach (int idx in face)
                {
                    Vector3D v = modeloAtual.Vertices[idx];
                    Vector3D vt = mTransf.Transformar(v); // Transformação Mundo
                    vt = mProj.Transformar(vt);           // Projeção

                    // Coordenadas Ecrã
                    pts.Add(new PointF(cx + vt.x, cy - vt.y));
                }

                if (pts.Count > 2)
                    g.DrawPolygon(caneta, pts.ToArray());
            }
        }

        // --- EVENTOS ---
        private void trbRotY_Scroll(object sender, EventArgs e)
        {
            anguloY = trbRotY.Value;
            pctBox.Invalidate();
        }

        private void trbEscala_Scroll(object sender, EventArgs e)
        {
            escala = trbEscala.Value;
            pctBox.Invalidate();
        }

        private void rbPerspetiva_CheckedChanged(object sender, EventArgs e)
        {
            pctBox.Invalidate();
        }


        private void trbRaio_Scroll(object sender, EventArgs e)
        {
            raioAtual = trbRaio.Value / 10.0f;

            // Recriar o modelo atual com novo raio
            if (modeloAtual.Nome == "Cone")
                modeloAtual = Modelo3D.CriarCone(20, raioAtual, alturaAtual);
            else if (modeloAtual.Nome == "Cilindro")
                modeloAtual = Modelo3D.CriarCilindro(20, raioAtual, alturaAtual);
            else if (modeloAtual.Nome == "Esfera")
                modeloAtual = Modelo3D.CriarEsfera(12, 20, raioAtual);

            AtualizarInfo();
            pctBox.Invalidate(); // redesenha em tempo real
        }

        private void trbAltura_Scroll(object sender, EventArgs e)
        {
            alturaAtual = trbAltura.Value / 10.0f;

            if (modeloAtual.Nome == "Cone")
                modeloAtual = Modelo3D.CriarCone(20, raioAtual, alturaAtual);
            else if (modeloAtual.Nome == "Cilindro")
                modeloAtual = Modelo3D.CriarCilindro(20, raioAtual, alturaAtual);

            AtualizarInfo();
            pctBox.Invalidate();
        }


        private void btnCubo_Click(object sender, EventArgs e)
        {
            modeloAtual = Modelo3D.CriarCubo();
            AtualizarInfo();
            pctBox.Invalidate();
        }

        private void btnCone_Click(object sender, EventArgs e)
        {
            modeloAtual = Modelo3D.CriarCone(20, raioAtual, alturaAtual);
            AtualizarInfo();
            pctBox.Invalidate();
        }

        private void btnCilindro_Click(object sender, EventArgs e)
        {
            modeloAtual = Modelo3D.CriarCilindro(20, raioAtual, alturaAtual);
            AtualizarInfo();
            pctBox.Invalidate();
        }



        private void btnEsfera_Click(object sender, EventArgs e)
        {
            modeloAtual = Modelo3D.CriarEsfera(12, 20, raioAtual);
            AtualizarInfo();
            pctBox.Invalidate();
        }


        private void AtualizarInfo()
        {
            if (modeloAtual != null)
                lblArestas.Text = "Arestas Totais: " + modeloAtual.CalcularComprimentoArestas().ToString("F2");
        }

        private void btnCarregarModelo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Path.Combine(Application.StartupPath, "Modelos");
            dlg.Filter = "Ficheiros 3D|*.obj;*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    modeloAtual = Modelo3D.LerModelo(dlg.FileName);
                    AtualizarInfo();
                    pctBox.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar modelo: " + ex.Message);
                }
            }
        }

        



    }
}