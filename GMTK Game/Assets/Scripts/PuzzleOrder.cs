using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PuzzleOrder : MonoBehaviour
{
    // Start is called before the first frame update
	public bool bookshelf1, bookshelf2, bookshelf3, bookshelf4;
	public int howManyLeft;
	public GameObject player;
	private PlayerInteract interaction;
	//The answer to the bookshelf puzzle is 3142
    void Start()
    {
        bookshelf1 = false;
		bookshelf2 = false;
		bookshelf3 = false;
		bookshelf4 = false;
		howManyLeft = 4;
		interaction = player.GetComponent <PlayerInteract> ();
    }

    // Update is called once per frame
	//The idea is simple, reset after a wrong move is done
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
			checkBookshelf();
			
		checkWin();
    }
	//Check which bookshelf the player is lookin at
	public void checkBookshelf()
	{
		if(String.Compare(interaction.interObj.name, "BookshelfL (1)") == 0 && howManyLeft == 3)
		{
			bookshelf1 = true;
			--howManyLeft;
		}
		else if(String.Compare(interaction.interObj.name, "BookshelfL (2)") == 0 && howManyLeft == 1)
		{
			bookshelf2 = true;
			--howManyLeft;
		}
		else if(String.Compare(interaction.interObj.name, "BookshelfL (3)") == 0 && howManyLeft == 4)
		{
			bookshelf3 = true;
			--howManyLeft;
		}
		else if(String.Compare(interaction.interObj.name, "BookshelfL (4)") == 0 && howManyLeft == 2)
		{
			bookshelf4 = true;
			--howManyLeft;
		}
		else
		{
			reset();
		}
	}
	
	public void checkWin()
	{
		if(howManyLeft == 0)
		{
			Debug.Log("u win");
			//TODO: door opens and u get key and spaceship object
		}
	}
	
	public void reset()
	{
		bookshelf1 = false;
		bookshelf2 = false;
		bookshelf3 = false;
		bookshelf4 = false;
		howManyLeft = 4;
	}
}
