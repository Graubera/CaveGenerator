using UnityEngine;
using System.Collections;

public class PlayerMovement2D : MonoBehaviour {

    Rigidbody2D rb;
    Vector2 velocity;

	
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
        velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * 10;

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
	
	}
}
