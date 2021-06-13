using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjInteract : MonoBehaviour
{
    public Canvas dialogBox;
	public Text changedText;
	public Text defaultText;
	void Start()
	{
		dialogBox.enabled = false;
	}
	void Update()
	{
		defaultText.text = changedText.text;
	}
    public void openDialogBox()
	{
		defaultText.text = changedText.text;
		dialogBox.enabled = true;
	}
	public void closeDialogBox()
	{
		dialogBox.enabled = false;
	}

}
