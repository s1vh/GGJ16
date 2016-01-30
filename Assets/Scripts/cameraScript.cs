using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
		}
	}


	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "scene_1")
		{
			Debug.Log("Centrar viñeta 1");
		}
		else if(col.gameObject.tag == "scene_2")
		{
			Debug.Log("Centrar viñeta 2");
		}
		else if(col.gameObject.tag == "scene_3")
		{
			Debug.Log("Centrar viñeta 3");
		}
		else if(col.gameObject.tag == "scene_4")
		{
			Debug.Log("Centrar viñeta 4");
		}
		else if(col.gameObject.tag == "scene_5")
		{
			Debug.Log("Centrar viñeta 5");
		}
	}


}
