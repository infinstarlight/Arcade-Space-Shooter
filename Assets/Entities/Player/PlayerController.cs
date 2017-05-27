using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

        rb2d = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //FixedUpdate is called at a predetermined refresh time 
    //and is independent of fps
    void FixedUpdate()
    {
		//Store current vertical input as float
		float moveHorizontal = Input.GetAxis("Horizontal");

        //Store current vertical input as float
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two floats to create Vector2 variable movement
        Vector2 Movement = new Vector2(moveHorizontal, moveVertical);

        //call the force function to supply movement multiplied by speed
        rb2d.AddForce(Movement * Speed);
    }
}
