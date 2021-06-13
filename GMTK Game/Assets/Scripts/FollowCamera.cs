using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public float interpVelocity;
	public float minDistance;
	public float followDistance;
	public int test;
	public GameObject target1;
	public GameObject target2;
	public Vector3 offset;
	Vector3 targetPos;
	private Vector3 centerOfTargets;
	// Use this for initialization
	void Start () {
		targetPos = transform.position;
		centerOfTargets = ((target1.transform.position + target2.transform.position) / 2); 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (target1)
		{
			Vector3 posNoZ = transform.position;
			
			centerOfTargets = ((target1.transform.position + target2.transform.position) / 2);
			
			posNoZ.z = centerOfTargets.z;
			
			Vector3 targetDirection = (centerOfTargets - posNoZ);

			interpVelocity = targetDirection.magnitude * 5f;

			targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime); 

			transform.position = Vector3.Lerp( transform.position, targetPos + offset, 0.10f);
		}
	}
}

// Original post with image here  >  http://unity3diy.blogspot.com/2015/02/unity-2d-camera-follow-script.html