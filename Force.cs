using UnityEngine;

public static class Force
{
    public static void MovementForce(this Rigidbody2D Rigidbody2D, Vector2 Movement, float MovementForce, float DeltaTime)
    {
        Rigidbody2D.AddForce(Movement * MovementForce * DeltaTime, ForceMode2D.Impulse);
    }

    public static void JumpForce(this Rigidbody2D Rigidbody2D, float JumpForce, float DeltaTime)
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce * DeltaTime, ForceMode2D.Impulse);
    }

    public static void GravityForce(this Rigidbody2D Rigidbody2D, float GravityForce, float DeltaTime)
    {
        Rigidbody2D.AddForce(Vector2.down * GravityForce * DeltaTime, ForceMode2D.Impulse);
    }
}
