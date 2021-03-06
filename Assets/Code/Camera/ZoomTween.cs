﻿using UnityEngine;
using System.Collections;

public class ZoomTween : MonoBehaviour {

	private float timer = 0;
	private float timer2 = 0;
	private bool zoomIn = false;
	private bool zoomOut = false;
	public Background background;
	private Camera camera;


	// Use this for initialization
	void Start () {
		camera = Camera.main;


	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.B) && !zoomOut) {
			ZoomOut();
		}
		if (Input.GetKey (KeyCode.V) && !zoomIn) {
			ZoomIn();
		}






		if (zoomOut && !zoomIn) {	
			if (timer < 1) {
				timer +=Time.deltaTime;
				float x = Mathf.Lerp(60,130,timer);
				camera.orthographicSize = x;

			}else {
				zoomOut = false;
				timer = 0;
			}
		}


		if (zoomIn && !zoomOut) {	
			if (timer2 < 1) {
				timer2 +=Time.deltaTime;
				float x = Mathf.Lerp(130,60,timer2);
				camera.orthographicSize = x;

			}else {
				zoomIn = false;
				timer2 = 0;
			}
		}





	}


	public void ZoomIn() {
		zoomIn = true;
		//camera.GetComponent<FollowPlayer>().enabled = true;
	}

	public void ZoomOut() {
		zoomOut = true;
		//camera.GetComponent<FollowPlayer>().enabled = false;
	}



}
