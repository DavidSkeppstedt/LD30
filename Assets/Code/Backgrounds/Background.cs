using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
	public GameObject prefab;
	private GameObject go; 
	private GameObject background;
	private Vector3 pos; 
	public int stars; 
	 

	// Use this for initialization
	void Start () {
		SpriteRenderer sr=GetComponent<SpriteRenderer>();
		if(sr==null) return;
		
		transform.localScale=new Vector3(100,100,1);
		
		float width=sr.sprite.bounds.size.x;
		float height=sr.sprite.bounds.size.y;
		
		
		float worldScreenHeight=Camera.main.orthographicSize*2f;
		float worldScreenWidth=worldScreenHeight/Screen.height*Screen.width;
		
		Vector3 xWidth = transform.localScale;
		xWidth.x=worldScreenWidth / width;
		transform.localScale=xWidth;
		//transform.localScale.x = worldScreenWidth / width;
		Vector3 yHeight = transform.localScale;
		yHeight.y=worldScreenHeight / height;
		transform.localScale=yHeight;







		for(int i = 0;i < stars; i++ ){
			pos = new Vector3(Random.Range(0,Screen.width),Random.Range(0,Screen.height),0);
			go = Instantiate (prefab, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity) as GameObject;
			go.transform.Translate(0,0,10);
			go.transform.parent = this.gameObject.transform;
		}


	}

	public void UpdateBackground () {

		for (int i = 0; i< stars; i++) {
			Destroy(this.gameObject.transform.GetChild(i).gameObject);
		}



		SpriteRenderer sr=GetComponent<SpriteRenderer>();
		if(sr==null) return;
		
		transform.localScale=new Vector3(100,100,1);
		
		float width=sr.sprite.bounds.size.x;
		float height=sr.sprite.bounds.size.y;
		
		
		float worldScreenHeight=Camera.main.orthographicSize*2f;
		float worldScreenWidth=worldScreenHeight/Screen.height*Screen.width;
		
		Vector3 xWidth = transform.localScale;
		xWidth.x=worldScreenWidth / width;
		transform.localScale=xWidth;
		//transform.localScale.x = worldScreenWidth / width;
		Vector3 yHeight = transform.localScale;
		yHeight.y=worldScreenHeight / height;
		transform.localScale=yHeight;

		for(int i = 0;i < stars; i++ ){
			pos = new Vector3(Random.Range(0,Screen.width),Random.Range(0,Screen.height),0);
			go = Instantiate (prefab, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity) as GameObject;
			go.transform.Translate(0,0,10);
			go.transform.parent = this.gameObject.transform;
		}


	}



	// Update is called once per frame
	void Update () {
	
	}
}
