using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    Rigidbody rb;
    Vector3 velocity;

	
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical")).normalized * 10;

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
	
	}
}
