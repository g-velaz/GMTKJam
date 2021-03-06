using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public GameObject target1;
	public GameObject target2;
	public float bottomBorder;
	public float topBorder;
	public float leftBorder;
	public float rightBorder;
	private Vector3 centerOfTargets;
	// Use this for initialization
	void Start () {
		centerOfTargets = ((target1.transform.position + target2.transform.position) / 2); 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (target1)
		{
			
			centerOfTargets = ((target1.transform.position + target2.transform.position) / 2);

			transform.position = new Vector3(
					Mathf.Clamp(centerOfTargets.x, leftBorder, rightBorder),
					Mathf.Clamp(centerOfTargets.y, topBorder, bottomBorder),
					transform.position.z);
		}
	}
}

// Original post with image here  >  http://unity3diy.blogspot.com/2015/02/unity-2d-camera-follow-script.html