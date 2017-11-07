using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    //Access Modifiers
    //public - anyone can see it
    //(default) private - only this object can see it
    //protected - only this object and child objects can see it
    public float speed = 5;
 


	// Use this for initialization
	void Start () {//called when object is created
		
	}
	
	// Update is called once per frame
	void Update () {//called every frame of the game
            
        transform.position += new Vector3(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);

        transform.position += new Vector3(0, speed * Input.GetAxis("Vertical") * Time.deltaTime, 0);
        
	}
}
