﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StuffForTitleScreen : MonoBehaviour {

	public void Button(int index) 
	{
		StartCoroutine (launchAfterDelay (index));
	}
	
	public void Button(string levelName)
	{
		StartCoroutine (launchAfterDelay (levelName));
	}

	public IEnumerator launchAfterDelay(string levelName)
	{
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene (levelName);
	}

	public IEnumerator launchAfterDelay(int index)
	{
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene (index);
	}
}
