using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Force : MonoBehaviour
{
    [Header("Gravity Settings")]
    [SerializeField] public float GravityForce;
    [SerializeField] public float CurrentGravity;
    [SerializeField] float JumpForce;

    [Header("Component")]
    [SerializeField] Rigidbody Rigidbody;

    public void GetGravityForce() => Rigidbody.AddForce(Vector3.down * GravityForce * Time.fixedDeltaTime, ForceMode.Impulse);

    public void GetJumpForce() => Rigidbody.AddForce(Vector3.up * JumpForce * Time.fixedDeltaTime, ForceMode.Impulse);
}