using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour { 
    public float speed = 5;
    private Rigidbody rb;
 


	// Use this for initialization
	void Start () {//called when object is created
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {//called every frame of the game
      
        rb.MovePosition(transform.position + 
            new Vector3(Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0) * speed * Time.deltaTime);
	}
}
