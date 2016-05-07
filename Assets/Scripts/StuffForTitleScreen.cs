using UnityEngine;
using System.Collections;

public class StuffForTitleScreen : MonoBehaviour {
	public void Button(int index) 
	{
		Application.LoadLevel(index);
	}
	
	public void Button(string levelName)
	{
		Application.LoadLevel(levelName);
	}
}
