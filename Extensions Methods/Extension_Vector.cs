using UnityEngine;

public static class Extension_Vector
{
    public static Vector3 SetX(this Vector3 vector, float x)
    {
        return new Vector3(x, vector.y, vector.z);
    }
    public static Vector3 SetY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, y, vector.z);
    }
    public static Vector3 SetZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, z);
    }

    public static Vector3 AddX(this Vector3 vector, float x)
    {
        return new Vector3(vector.x + x, vector.y, vector.z);
    }
    public static Vector3 AddY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, vector.y + y, vector.z);
    }
    public static Vector3 AddZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, vector.z + z);
    }

    public static Vector3 SubtractX(this Vector3 vector, float x)
    {
        return new Vector3(vector.x - x, vector.y, vector.z);
    }
    public static Vector3 SubtractY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, vector.y - y, vector.z);
    }
    public static Vector3 SubtractZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, vector.z - z);
    }

    public static Vector3 MultiplyX(this Vector3 vector, float x)
    {
        return new Vector3(vector.x * x, vector.y, vector.z);
    }
    public static Vector3 MultiplyY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, vector.y * y, vector.z);
    }
    public static Vector3 MultiplyZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, vector.z * z);
    }

    public static Vector3 DivideX(this Vector3 vector, float x)
    {
        return new Vector3(vector.x / x, vector.y, vector.z);
    }
    public static Vector3 DivideY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, vector.y / y, vector.z);
    }
    public static Vector3 DivideZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, vector.z / z);
    }

    public static Vector2 SetX(this Vector2 vector, float x)
    {
        return new Vector2(x, vector.y);
    }
    public static Vector2 SetY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, y);
    }
    public static Vector2 AddX(this Vector2 vector, float x)
    {
        return new Vector2(vector.x + x, vector.y);
    }
    public static Vector2 AddY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, vector.y + y);
    }
    public static Vector2 SubtractX(this Vector2 vector, float x)
    {
        return new Vector2(vector.x - x, vector.y);
    }
    public static Vector2 SubtractY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, vector.y - y);
    }
    public static Vector2 MultiplyX(this Vector2 vector, float x)
    {
        return new Vector2(vector.x * x, vector.y);
    }
    public static Vector2 MultiplyY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, vector.y * y);
    }
    public static Vector2 DivideX(this Vector2 vector, float x)
    {
        return new Vector2(vector.x / x, vector.y);
    }
    public static Vector2 DivideY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, vector.y / y);
    }
    
}