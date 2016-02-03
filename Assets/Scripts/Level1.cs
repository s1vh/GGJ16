using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour
{
    public GameObject domainLevel1;
    Game game;

    public int nOpt = 4;
    public int nSeq = 4;
    public int difficulty = 0;

    public bool locked;

	// Use this for initialization
	void Start ()
    {
        game = domainLevel1.GetComponent<Game>();

        locked = true;
    }

	// Update is called once per frame
	void Update ()
    {

	}

    void OnMouseUp()
    {
        if (locked == true && game.gamestate != 1)
        {
            Debug.Log("Level 1 activated!");     // trace
            game.gamestate = 1;
            game.buildSeq(nOpt, nSeq, difficulty);
            locked = false;
        }

    }

}