using UnityEngine;

public static class Force
{
    public static void MovementForce(this Rigidbody Rigidbody, Vector3 Movement, float MovementForce)
    {
        Rigidbody.AddForce(Movement * MovementForce, ForceMode.Impulse);
    }

    public static void JumpForce(this Rigidbody Rigidbody, float JumpForce)
    {
        Rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
    }

    public static void GravityForce(this Rigidbody Rigidbody, float GravityForce)
    {
        Rigidbody.AddForce(Vector3.down * GravityForce, ForceMode.Impulse);
    }
}
