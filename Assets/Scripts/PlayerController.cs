using System.Numerics;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float movementSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerMovement();
    }   

    private void HandlePlayerMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        UnityEngine.Vector2 movement = new UnityEngine.Vector2(moveHorizontal, moveVertical);
        movement = UnityEngine.Vector2.ClampMagnitude(movement, 1.0f);
        _rb.linearVelocity = movement * movementSpeed;
    }

}
