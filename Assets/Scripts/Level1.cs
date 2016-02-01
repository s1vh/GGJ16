using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Level1 : MonoBehaviour
{
    public GameObject backgroundLevel1;
    cameraScript game;

    public List<int> seq = new List<int>();
    public int nOpt = 4;
    public int nSeq = 4;
    public int inputOrder = 0;
    public int difficulty = 0;
    public bool locked = true;

	// Use this for initialization
	void Start ()
    {
        game = backgroundLevel1.GetComponent<cameraScript>();
    }

	// Update is called once per frame
	void Update ()
    {

	}

    public void buildSeq(int r)     // r --> nOpt
    {   
        locked = true;

        while (seq.Count > 0)
        {
            seq.RemoveAt(0);        // clear the old Array if there is one
        }

        for (int i = 0; i < nSeq + difficulty; i++)
        {
            int n = Random.Range(1, r + 1);
            seq.Add(n);
        }

        showSeq(seq);
        locked = false;

    }

    public void showSeq(List<int> l)
    {
        for (int i = 0; i < l.Count; i++)   // trace
        {    
            Debug.Log(l[i]);
        }

    }
		
}