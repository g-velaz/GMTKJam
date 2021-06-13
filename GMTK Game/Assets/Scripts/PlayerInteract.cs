using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInteract : MonoBehaviour
{
	public GameObject interObj = null;
	public ObjInteract objScript = null;
	public bool isSlime = false;
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.X) && interObj != null )
		{
			if(objScript.dialogBox.isActiveAndEnabled)
			{
				interObj.SendMessage("closeDialogBox");
			}
			else
			{
				interObj.SendMessage("openDialogBox");
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D o)
	{
		if(String.Compare(o.name, "Walls and collision") != 0 )
		{
			interObj = o.gameObject;
			objScript = interObj.GetComponent <ObjInteract> ();
		}
		if(Input.GetKeyDown(KeyCode.X) && interObj != null)
		{
			if(objScript.dialogBox.isActiveAndEnabled)
			{
				interObj.SendMessage("closeDialogBox");
			}
			else
			{
				interObj.SendMessage("openDialogBox");
			}
		}
	}
	
	void OnTriggerExit2D(Collider2D o)
	{
		interObj = null;
		objScript = null;
	}
}
