using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Level1 : MonoBehaviour {

	public List<int> seq = new List<int>();
	public int dish;
    public int nSeq = 4;
    public int inputOrder = 0;

    bool show = true;


	// Use this for initialization
	void Start () {

		for (int i = 0; i < nSeq; i++) {

			createSeq(4);

		}

		for (int i = 0; i < seq.Count; i++){    // trace

			Debug.Log(seq[i]);

		}

	}

	// Update is called once per frame
	void Update () {
			
	}

	private void createSeq(int r) {

		int n;
		do {
			n = Random.Range (1, r + 1);
		} while (seq.Contains (n));
	
		seq.Add (n);

	}
		
}