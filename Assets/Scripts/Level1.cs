using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Level1 : MonoBehaviour {

	public List<int> seq = new List<int>();
	public int dish;

	public List<int> seq2 = new List<int>();


	// Use this for initialization
	void Start () {

		for (int i = 0; i <= 3; i++){
			createSeq (4);

		}

		for (int i = 0; i < seq.Count; i++){
			Debug.Log (seq[i]);
		}



	}

	// Update is called once per frame
	void Update () {
		Debug.Log (dish);
	}

	private void createSeq(int r){

		int n;
		do {
			n = Random.Range (1, r + 1);
		} while (seq.Contains (n));
	
		seq.Add (n);

	}
		
}