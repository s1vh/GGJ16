﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour
{
    public GameObject backgroundLevel1;
    Level1 level1;

    public List<int> seq = new List<int>();
    public int inputOrder = 0;

    public int gamestate;   // 0 --> navigation, 1 --> playing, -1 --> game over
    public bool wait;

    float speed = 1f;
    float timeLeft = 31.0f;
    Camera cam = Camera.main;

    private TextMesh timer;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Initializing scene...");   // trace
        level1 = backgroundLevel1.GetComponent<Level1>();

        timer = GameObject.Find("Timer").GetComponent<TextMesh>();

        gamestate = 0;
        wait = true;
    }

    // Update is called once per frame
    void Update()
    {
        // these should be a SWITCH but they are fucking bugged at Unity
        // so let's code like retards
        if (gamestate == 0)
        {
            moveCamera();
        }

        if (wait == false)
        {
            if (gamestate == 1)
            {
                wait = true;
            }

        }

    }

    public void buildSeq(int r, int n, int d)   // r --> nOpt, n --> nSeq, d --> difficulty
    {
        while (seq.Count > 0)                   // clear the old Array if there is one
        {
            seq.RemoveAt(0);
        }

        for (int i = 0; i < n + d; i++)
        {
            int m = Random.Range(1, r + 1);
            seq.Add(m);
        }

        showSeq(seq);

    }

    public void showSeq(List<int> l)
    {
        for (int i = 0; i < l.Count; i++)
        {
            Debug.Log(l[i]);        // trace
        }

    }

    void moveCamera()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

            if (timer)
            {
                timer.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));

            if (timer)
            {
                timer.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));

            if (timer)
            {
                timer.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));

            if (timer)
            {
                timer.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            }
        }
    }

    void timerFunc()
    {
        timeLeft -= Time.deltaTime;
        timer.text = ((int)timeLeft).ToString();

        if (timeLeft < 0)
        {
            Destroy(timer);

            // GAME OVER
            //gamestate = -1;
        }

    }

}