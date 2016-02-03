using UnityEngine;
using System.Collections;
//using System.Collections.Generic;


public class Level1 : MonoBehaviour
{
    public GameObject domainLevel1;
    Game game;

    //public List<int> seq = new List<int>();
    public int nOpt = 4;
    public int nSeq = 4;
    //public int inputOrder = 0;
    public int difficulty = 0;
    public bool locked;

	// Use this for initialization
	void Start ()
    {
        game = domainLevel1.GetComponent<Game>();
        //game.buildSeq(nOpt, nSeq, difficulty);
        //Debug.Log("gamestate="+game.gamestate);

        locked = true;
    }

	// Update is called once per frame
	void Update ()
    {

	}
		
}