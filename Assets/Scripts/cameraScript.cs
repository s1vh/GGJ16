using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class cameraScript : MonoBehaviour {

	float speed = 1f;

	float timeLeft = 31.0f;

	private TextMesh timer;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Timer").GetComponent<TextMesh> ();
	}

	void Update()
	{
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
			Debug.Log("Centrar viñeta 1");
			SceneManager.LoadScene ("Level1");
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
