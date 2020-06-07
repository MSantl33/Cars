﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenager : MonoBehaviour {


	public void LoadLevel(string name)
	{
		Debug.Log ("Učitavanje razine: " + name);
		Application.LoadLevel (name);
	}
	public void QuitRequest()
	{
		Debug.Log ("Gašenje!");
		Application.Quit ();
	}

	/*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/

	public void Pause()
	{
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}
}
