using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMirrorScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);
	public Animator animator;
	private Vector2 movement;
	private Rigidbody2D rigidbodyComponent;
	
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
		animator.SetFloat("LRMove", inputX);
		animator.SetFloat("UDMove", inputY);
		
		if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
		{
			animator.SetBool("LeftRight", true);
		}
		else if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.UpArrow))
		{
			animator.SetBool("LeftRight", false);
		}
		
    }
	
	void FixedUpdate()
	{
		if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();
		
		rigidbodyComponent.velocity = movement;
	}
	
	/*
	TODO: Add collisions for objects, interact button, if mirror is done, reverse buttons, push button?, and animations that correspond to movement*/
}
