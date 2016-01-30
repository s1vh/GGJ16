using UnityEngine;
using System.Collections;

public class dish2 : MonoBehaviour {

	public GameObject backgroundLevel1;
	Level1 level1;

	// Use this for initialization
	void Start () {

		level1 = backgroundLevel1.GetComponent<Level1> ();


	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseUp(){


		level1.dish = 2;

		level1.seq2.Add (2);


	}
}