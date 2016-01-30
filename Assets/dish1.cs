using UnityEngine;
using System.Collections;

public class dish1 : MonoBehaviour {

	Level1 level1;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){

		Level1 dishLevel1 = gameObject.GetComponent<Level1> ();
		dishLevel1.dish = 1;


	}
}
