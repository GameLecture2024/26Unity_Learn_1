using UnityEngine;


public static class TransformExtensions
{
    public static void MovePosition(this Transform transform, Vector3 position)
    {
        transform.localPosition += position;
    }
}

// 