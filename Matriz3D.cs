using System;

public class Vector3D
{
    public float x, y, z, w;

    public Vector3D() { x = 0; y = 0; z = 0; w = 1; }
    public Vector3D(float x, float y, float z) { this.x = x; this.y = y; this.z = z; this.w = 1; }
    public Vector3D(float x, float y, float z, float w) { this.x = x; this.y = y; this.z = z; this.w = w; }

    // Clone
    public Vector3D Clone() { return new Vector3D(x, y, z, w); }

    // Somar
    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    }

    // Subtrair
    public static Vector3D operator -(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
    }
}