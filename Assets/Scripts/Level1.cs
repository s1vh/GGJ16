using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Level1 : MonoBehaviour {

	public List<int> seq = new List<int>();
	public int dish;
    public int nOpt = 4;
    public int nSeq = 4;
    public int inputOrder = 0;
    public int difficulty = 0;

    bool show = true;

	public float timeLeft;

	private TextMesh timer;

	// Use this for initialization
	void Start () {

        buildSeq(nOpt);

		timer = GameObject.Find ("Timer").GetComponent<TextMesh> ();

	}

	// Update is called once per frame
	void Update () {

		if (timeLeft >= 0) {
			timerFunc ();
		}
		timer.text = "GAME OVER";
	}

	void timerFunc(){
		
		timer.text = ((int) timeLeft).ToString();
		if (timeLeft < 0){
			Destroy (timer);
		}

	}

    public void buildSeq(int r) {   // r --> nOpt

        while (seq.Count > 0) {

            seq.RemoveAt(0);        // clear the old Array if there is one

        }

        for (int i = 0; i < nSeq + difficulty; i++) {

            int n = Random.Range(1, r + 1);
            seq.Add(n);

        }

        showSeq(seq);

    }

    public void showSeq(List<int> l) {

        for (int i = 0; i < l.Count; i++) {    // trace

            Debug.Log(l[i]);

        }

    }
		
}