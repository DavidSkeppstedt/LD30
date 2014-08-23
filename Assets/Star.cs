using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {

	public Sprite[] stars;
	private SpriteRenderer sr;
	private Color[] color;
	// Use this for initialization
	void Start () {
		color = new Color[20];
		color [0] = new Vector4 (0.62f,0.70f,1f,1f);
		color [1] = new Vector4 (0.64f,0.72f,1f,1f);
		color [2] = new Vector4 (0.65f,0.73f,1f,1f);
		color [3] = new Vector4 (0.66f,0.75f,1f,1f);
		color [4] = new Vector4 (0.68f,0.76f,1f,1f);
		color [5] = new Vector4 (0.72f,0.8f,1f,1f);
		color [6] = new Vector4 (0.75f,0.81f,1f,1f);
		color [7] = new Vector4 (0.79f,0.84f,1f,1f);
		color [8] = new Vector4 (0.89f,0.90f,1f,1f);
		color [9] = new Vector4 (0.92f,0.93f,1f,1f);
		color [10] = new Vector4 (0.98f,0.97f,1f,1f);
		color [11] = new Vector4 (1f,0.97f,0.97f,1f);
		color [12] = new Vector4 (1f,0.96f,0.92f,1f);
		color [13] = new Vector4 (1f,0.95f,0.90f,1f);
		color [14] = new Vector4 (1f,0.94f,0.87f,1f);
		color [15] = new Vector4 (1f,0.92f,0.82f,1f);
		color [16] = new Vector4 (1f,0.84f,0.68f,1f);
		color [17] = new Vector4 (1f,0.77f,0.56f,1f);
		color [18] = new Vector4 (1f,0.74f,0.49f,1f);
		color [19] = new Vector4 (1f,0.73f,0.48f,1f);


		sr = gameObject.GetComponent<SpriteRenderer> ();
		sr.sprite = stars [Random.Range(0,stars.Length)];
		sr.color = color[Random.Range(0,color.Length)]; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
