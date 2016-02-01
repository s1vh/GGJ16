using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;

public class level1button3 : MonoBehaviour
{

    public GameObject domainLevel1;
    public GameObject backgroundLevel1;

    Game game;
    Level1 level1;

    // Use this for initialization
    void Start()
    {
        game = domainLevel1.GetComponent<Game>();
        level1 = backgroundLevel1.GetComponent<Level1>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseUp()
    {
        if (!game.locked && game.gamestate == 0)
        {
            if (game.seq[game.inputOrder] == 3)         // if EQUAL
            {
                Debug.Log("Ok");            // trace
                game.inputOrder++;

                if (game.inputOrder == game.seq.Count)  // if COMPLETED
                {
                    Debug.Log("YOU WIN");   // trace
                    level1.difficulty++;

                    //reset routine
                    game.inputOrder = 0;
                    game.buildSeq(level1.nOpt, level1.nSeq, level1.difficulty);
                }

            } else {                                    // not EQUAL

                Debug.Log("FAIL");          // trace
                game.inputOrder = 0;
                game.showSeq(game.seq);
            }

        } else {

            Debug.Log("locked!");           // trace
        }

    }

}