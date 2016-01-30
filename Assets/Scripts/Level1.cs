using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Level1 : MonoBehaviour {

	public List<int> seq = new List<int>();
	public int dish;

	public List<int> seq2 = new List<int>();

	bool show = true;


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
		//Debug.Log (dish);
		if(seq2.Count == 4 && show == true){
			showSeqUser ();
			compareSeqs ();
			seq2.Clear();
		}
			


	}

	private void createSeq(int r){

		int n;
		do {
			n = Random.Range (1, r + 1);
		} while (seq.Contains (n));
	
		seq.Add (n);

	}

	private void showSeqUser(){

		for (int i = 0; i < seq2.Count; i++) {
			Debug.Log (seq2 [i]);
		}
			
		show = false;

	}

	private void compareSeqs(){

		if (seq2.Count == 4 && seq [0] == seq2 [0] && seq [1] == seq2 [1] && seq [2] == seq2 [2] && seq [3] == seq2 [3]) {
			win ();
		}

	}

	private void win(){
		Debug.Log("WIN");
	}
		
}