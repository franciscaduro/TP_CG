using System;

namespace TrabalhoCG_Prop3
{
    public class Matriz3D
    {
        public float[,] m = new float[4, 4];

        // Construtor
        public Matriz3D() { Identidade(); }

        // Identidade
        public void Identidade()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    m[i, j] = (i == j) ? 1 : 0;
        }

        // Multiplicação Matriz * Matriz
        public static Matriz3D operator *(Matriz3D m1, Matriz3D m2)
        {
            Matriz3D res = new Matriz3D();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    res.m[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                        res.m[i, j] += m1.m[i, k] * m2.m[k, j];
                }
            }
            return res;
        }

        // Transformar Ponto (Matriz * Vector)
        public Vector3D Transformar(Vector3D v)
        {
            float x = m[0, 0] * v.x + m[0, 1] * v.y + m[0, 2] * v.z + m[0, 3] * v.w;
            float y = m[1, 0] * v.x + m[1, 1] * v.y + m[1, 2] * v.z + m[1, 3] * v.w;
            float z = m[2, 0] * v.x + m[2, 1] * v.y + m[2, 2] * v.z + m[2, 3] * v.w;
            float w = m[3, 0] * v.x + m[3, 1] * v.y + m[3, 2] * v.z + m[3, 3] * v.w;

            if (w != 0 && w != 1) // Normalização Homogénea
                return new Vector3D(x / w, y / w, z / w, 1);

            return new Vector3D(x, y, z, w);
        }

        // Escala
        public static Matriz3D Escala(float sx, float sy, float sz)
        {
            Matriz3D mat = new Matriz3D();
            mat.m[0, 0] = sx; mat.m[1, 1] = sy; mat.m[2, 2] = sz;
            return mat;
        }

        // Rotação Y
        public static Matriz3D RotacaoY(float theta)
        {
            Matriz3D mat = new Matriz3D();
            float rad = theta * (float)Math.PI / 180.0f;
            float c = (float)Math.Cos(rad);
            float s = (float)Math.Sin(rad);
            mat.m[0, 0] = c; mat.m[0, 2] = s;
            mat.m[2, 0] = -s; mat.m[2, 2] = c;
            return mat;
        }

        // Projeção Perspetiva
        public static Matriz3D ProjPerspetiva(float d)
        {
            Matriz3D mat = new Matriz3D();
            mat.m[3, 2] = -1 / d;
            return mat;
        }
    }
}