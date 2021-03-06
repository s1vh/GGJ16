﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class dish2 : MonoBehaviour
{

    public GameObject backgroundLevel1;
    Level1 level1;

    // Use this for initialization
    void Start()
    {
        level1 = backgroundLevel1.GetComponent<Level1>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseUp()
    {
        level1.dish = 2;

        if (level1.seq[level1.inputOrder] == 2)         // if EQUAL
        {
            Debug.Log("Ok");            // trace
            level1.inputOrder++;

            if (level1.inputOrder == level1.seq.Count)  // if COMPLETED
            {
                Debug.Log("YOU WIN");   // trace
                level1.difficulty++;


				SceneManager.LoadScene ("Main");


                //reset routine
                level1.inputOrder = 0;
                level1.buildSeq(level1.nOpt);
            }

        } else {                                        // not EQUAL

            Debug.Log("FAIL");          // trace
            level1.inputOrder = 0;
            level1.showSeq(level1.seq);
        }

    }

}