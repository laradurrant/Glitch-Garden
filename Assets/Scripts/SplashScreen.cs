using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour {

	public float loadTime;
	private float waitTilTime;
	
	public LevelManager lv;

	void Start()
	{
		
		waitTilTime = Time.time + loadTime;
		
	}

	void Update()
	{
		
		
		if(Time.time > waitTilTime)
		{
			lv.LoadLevel("Start Menu");
		}
		
	}
	

}
