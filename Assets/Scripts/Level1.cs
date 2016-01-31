using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Level1 : MonoBehaviour {

	public List<int> seq = new List<int>();
	public int dish;
    public int nOpt = 4;
    public int nSeq = 4;
    public int inputOrder = 0;
    //public int difficulty = 0;

    bool show = true;

	// Use this for initialization
	void Start () {

        buildSeq();

	}

	// Update is called once per frame
	void Update () {
			
	}

    public void buildSeq() {

        for (int i = 0; i < nSeq; i++) {

            createSeq(nOpt);

        }

        for (int i = 0; i < seq.Count; i++) {    // trace

            Debug.Log(seq[i]);

        }

    }

    private void createSeq(int r) {

		int n;
		do {
			n = Random.Range (1, r + 1);
		} while (seq.Contains(n));
	
		seq.Add(n);

	}
		
}