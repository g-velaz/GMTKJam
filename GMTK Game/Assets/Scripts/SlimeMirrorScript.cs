using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMirrorScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);
	private Vector2 movement;
	private Rigidbody2D rigidbodyComponent;
	private 
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		movement = new Vector2( speed.x * inputX, speed.y * inputY);
    }
	
	void FixedUpdate()
	{
		if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();
		
		rigidbodyComponent.velocity = movement;
	}
	
	/*
	TODO: Add collisions for objects, interact button, if mirror is done, reverse buttons, push button?, and animations that correspond to movement*/
}