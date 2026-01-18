using System;
using System.Collections.Generic;
using System.IO; 

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

        public static Modelo3D CriarCilindro(int fatias, float raio)
        {
            Modelo3D m = new Modelo3D { Nome = "Cilindro" };
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


        public static Modelo3D CriarCone(int fatias, float raio)
        {
            Modelo3D m = new Modelo3D { Nome = "Cone" };
            m.Vertices.Add(new Vector3D(0, 1, 0)); // pico

            for (int i = 0; i < fatias; i++)
            {
                float theta = 2.0f * (float)Math.PI * i / fatias;
                m.Vertices.Add(new Vector3D(
                    raio * (float)Math.Cos(theta),
                    -1,
                    raio * (float)Math.Sin(theta)));
            }

            for (int i = 0; i < fatias; i++)
            {
                int atual = i + 1;
                int prox = ((i + 1) % fatias) + 1;
                m.Faces.Add(new int[] { 0, prox, atual });
            }

            return m;
        }

        public static Modelo3D CriarEsfera(int stacks, int slices, float raio)
        {
            Modelo3D m = new Modelo3D { Nome = "Esfera" };

            for (int i = 0; i <= stacks; i++)
            {
                float phi = (float)Math.PI * i / stacks;
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

            for (int i = 0; i < stacks; i++)
            {
                for (int j = 0; j < slices; j++)
                {
                    int a = i * slices + j;
                    int b = i * slices + (j + 1) % slices;
                    int c = (i + 1) * slices + (j + 1) % slices;
                    int d = (i + 1) * slices + j;

                    m.Faces.Add(new int[] { a, b, c, d });
                }
            }

            return m;
        }

        public static Modelo3D LerModelo(string caminhoFicheiro)
        {
            string ext = Path.GetExtension(caminhoFicheiro).ToLower();
            if (ext == ".obj")
                return LerOBJ(caminhoFicheiro);
            else if (ext == ".txt")
                return LerTXT(caminhoFicheiro);
            else
                throw new Exception("Formato de ficheiro não suportado!");
        }

        // Leitura OBJ
        private static Modelo3D LerOBJ(string caminho)
        {
            Modelo3D m = new Modelo3D();
            foreach (string linha in File.ReadAllLines(caminho))
            {
                if (linha.StartsWith("v "))
                {
                    string[] partes = linha.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    float x = float.Parse(partes[1]);
                    float y = float.Parse(partes[2]);
                    float z = float.Parse(partes[3]);
                    m.Vertices.Add(new Vector3D(x, y, z));
                }
                else if (linha.StartsWith("f "))
                {
                    string[] partes = linha.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] face = new int[partes.Length - 1];
                    for (int i = 1; i < partes.Length; i++)
                    {
                        // OBJ começa em 1 → converter para 0
                        string indiceStr = partes[i].Split('/')[0]; // ignora texturas/normais
                        face[i - 1] = int.Parse(indiceStr) - 1;
                    }
                    m.Faces.Add(face);
                }
            }
            return m;
        }

        // Leitura TXT
        private static Modelo3D LerTXT(string caminho)
        {
            Modelo3D m = new Modelo3D();
            bool lendoVertices = false;
            bool lendoFaces = false;

            foreach (string linha in File.ReadAllLines(caminho))
            {
                string l = linha.Trim();
                if (l == "") continue;

                if (l.ToUpper() == "VERTICES")
                {
                    lendoVertices = true;
                    lendoFaces = false;
                    continue;
                }
                else if (l.ToUpper() == "FACES")
                {
                    lendoVertices = false;
                    lendoFaces = true;
                    continue;
                }

                if (lendoVertices)
                {
                    string[] partes = l.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    float x = float.Parse(partes[0]);
                    float y = float.Parse(partes[1]);
                    float z = float.Parse(partes[2]);
                    m.Vertices.Add(new Vector3D(x, y, z));
                }
                else if (lendoFaces)
                {
                    string[] partes = l.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] face = new int[partes.Length];
                    for (int i = 0; i < partes.Length; i++)
                        face[i] = int.Parse(partes[i]);
                    m.Faces.Add(face);
                }
            }

            return m;
        }
    }
}