using System;
using System.Collections.Generic;

namespace TrabalhoCG_Prop3
{
    public class Modelo3D
    {
        public List<Vector3D> Vertices = new List<Vector3D>();
        public List<int[]> Faces = new List<int[]>();
        public string Nome;

        public float CalcularComprimentoArestas()
        {
            float total = 0;
            foreach (var face in Faces)
            {
                for (int i = 0; i < face.Length; i++)
                {
                    Vector3D v1 = Vertices[face[i]];
                    Vector3D v2 = Vertices[face[(i + 1) % face.Length]];
                    float dist = (float)Math.Sqrt(Math.Pow(v1.x - v2.x, 2) + Math.Pow(v1.y - v2.y, 2) + Math.Pow(v1.z - v2.z, 2));
                    total += dist;
                }
            }
            return total / 2;
        }

        public static Modelo3D CriarCubo()
        {
            Modelo3D m = new Modelo3D { Nome = "Cubo" };
            // Vértices
            m.Vertices.Add(new Vector3D(-1, -1, 1));
            m.Vertices.Add(new Vector3D(1, -1, 1));
            m.Vertices.Add(new Vector3D(1, 1, 1));
            m.Vertices.Add(new Vector3D(-1, 1, 1));
            m.Vertices.Add(new Vector3D(-1, -1, -1));
            m.Vertices.Add(new Vector3D(1, -1, -1));
            m.Vertices.Add(new Vector3D(1, 1, -1));
            m.Vertices.Add(new Vector3D(-1, 1, -1));
            // Faces
            m.Faces.Add(new int[] { 0, 1, 2, 3 });
            m.Faces.Add(new int[] { 5, 4, 7, 6 });
            m.Faces.Add(new int[] { 1, 5, 6, 2 });
            m.Faces.Add(new int[] { 4, 0, 3, 7 });
            m.Faces.Add(new int[] { 3, 2, 6, 7 });
            m.Faces.Add(new int[] { 4, 5, 1, 0 });
            return m;
        }

        public static Modelo3D CriarCilindro(int fatias = 20)
        {
            Modelo3D m = new Modelo3D { Nome = "Cilindro" };
            float raio = 1.0f;
            float altura = 2.0f;
            for (int i = 0; i < fatias; i++)
            {
                float theta = 2.0f * (float)Math.PI * i / fatias;
                float x = raio * (float)Math.Cos(theta);
                float z = raio * (float)Math.Sin(theta);
                m.Vertices.Add(new Vector3D(x, -altura / 2, z));
                m.Vertices.Add(new Vector3D(x, altura / 2, z));
            }
            for (int i = 0; i < fatias; i++)
            {
                int b1 = i * 2;
                int t1 = i * 2 + 1;
                int b2 = ((i + 1) % fatias) * 2;
                int t2 = ((i + 1) % fatias) * 2 + 1;
                m.Faces.Add(new int[] { b1, b2, t2, t1 });
            }
            return m;
        }

        public static Modelo3D CriarCone(int fatias = 20)
        {
            Modelo3D m = new Modelo3D { Nome = "Cone" };
            float raio = 1.0f;
            m.Vertices.Add(new Vector3D(0, 1, 0)); // Pico
            for (int i = 0; i < fatias; i++)
            {
                float theta = 2.0f * (float)Math.PI * i / fatias;
                m.Vertices.Add(new Vector3D(raio * (float)Math.Cos(theta), -1, raio * (float)Math.Sin(theta)));
            }
            for (int i = 0; i < fatias; i++)
            {
                int atual = i + 1;
                int prox = ((i + 1) % fatias) + 1;
                m.Faces.Add(new int[] { 0, prox, atual });
            }
            return m;
        }

        public static Modelo3D CriarEsfera(int stacks = 12, int slices = 20)
        {
            Modelo3D m = new Modelo3D { Nome = "Esfera" };
            float raio = 1.0f;

            // Vértices
            for (int i = 0; i <= stacks; i++)
            {
                float phi = (float)Math.PI * i / stacks; // 0 -> PI
                float y = raio * (float)Math.Cos(phi);
                float r = raio * (float)Math.Sin(phi);

                for (int j = 0; j < slices; j++)
                {
                    float theta = 2.0f * (float)Math.PI * j / slices;
                    float x = r * (float)Math.Cos(theta);
                    float z = r * (float)Math.Sin(theta);

                    m.Vertices.Add(new Vector3D(x, y, z));
                }
            }

            // Faces
            for (int i = 0; i < stacks; i++)
            {
                for (int j = 0; j < slices; j++)
                {
                    int atual = i * slices + j;
                    int prox = i * slices + (j + 1) % slices;
                    int acima = (i + 1) * slices + j;
                    int acimaProx = (i + 1) * slices + (j + 1) % slices;

                    m.Faces.Add(new int[] { atual, prox, acimaProx, acima });
                }
            }

            return m;
        }

    }
}