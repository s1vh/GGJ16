using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	float speed = 1f;
	float timeLeft = 31.0f;
	bool isPlaying = false;

	Camera cam = Camera.main;

	private TextMesh timer;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Timer").GetComponent<TextMesh> ();
	}

	void Update()
	{
		if(!isPlaying){
			if(Input.GetKey(KeyCode.RightArrow))
			{
				transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
				if (timer) {
					timer.transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
				}
			}
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
				if (timer) {
					timer.transform.Translate (new Vector3 (-speed * Time.deltaTime, 0, 0));
				}
			}
			if(Input.GetKey(KeyCode.DownArrow))
			{
				transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
				if (timer) {
					timer.transform.Translate (new Vector3 (0, -speed * Time.deltaTime, 0));
				}
			}
			if(Input.GetKey(KeyCode.UpArrow))
			{
				transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
				if (timer) {
					timer.transform.Translate (new Vector3 (0, speed * Time.deltaTime, 0));
				}
			}

			if (timeLeft >= 0) {
				timerFunc ();
			}
		}
	}

	void timerFunc(){
		timeLeft -= Time.deltaTime;
		timer.text = ((int) timeLeft).ToString();
		if (timeLeft < 0){
			Destroy (timer);
		}

	}


	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "scene_1")
		{
			col.gameObject.GetComponent<Collider2D>().enabled = false;
			transform.position = new Vector3(
				col.gameObject.transform.position.x,
				col.gameObject.transform.position.y,
				-10);
			isPlaying = true;
			Debug.Log("Centrar viñeta 1");
		}
		else if(col.gameObject.tag == "scene_2")
		{
			col.gameObject.GetComponent<Collider2D>().enabled = false;
			col.gameObject.GetComponent<Collider2D>().enabled = false;
			transform.position = new Vector3(
				col.gameObject.transform.position.x,
				col.gameObject.transform.position.y,
				-10);
			isPlaying = true;
			Debug.Log("Centrar viñeta 2");
		}
		else if(col.gameObject.tag == "scene_3")
		{
			col.gameObject.GetComponent<Collider2D>().enabled = false;
			col.gameObject.GetComponent<Collider2D>().enabled = false;
			transform.position = new Vector3(
				col.gameObject.transform.position.x,
				col.gameObject.transform.position.y,
				-10);
			isPlaying = true;
			Debug.Log("Centrar viñeta 3");
		}
		else if(col.gameObject.tag == "scene_4")
		{
			col.gameObject.GetComponent<Collider2D>().enabled = false;
			col.gameObject.GetComponent<Collider2D>().enabled = false;
			transform.position = new Vector3(
				col.gameObject.transform.position.x,
				col.gameObject.transform.position.y,
				-10);
			isPlaying = true;
			Debug.Log("Centrar viñeta 4");
		}
		else if(col.gameObject.tag == "scene_5")
		{
			col.gameObject.GetComponent<Collider2D>().enabled = false;
			col.gameObject.GetComponent<Collider2D>().enabled = false;
			transform.position = new Vector3(
				col.gameObject.transform.position.x,
				col.gameObject.transform.position.y,
				-10);
			isPlaying = true;
			Debug.Log("Centrar viñeta 5");
		}
	}


}
