using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timeTxt;
    public TextMeshProUGUI messagesTxt;

    float time = 90;

    public static GameManager instance;

    public enum State { stopped, playing}
    public State myState;

   
    void Start()
    {
        instance = this;
        myState = State.stopped;
    }

    
    void Update()
    {
        switch (myState) 
        {
            case State.stopped:
                if (Input.GetButtonDown("Fire1")) 
                {
                    myState = State.playing;
                    time = 90;
                    messagesTxt.text = "";
                }
                break; 

            case State.playing:
                time -= Time.deltaTime;
                timeTxt.text = "" + time.ToString("00.00");
                if (time < 0)
                {
                    myState = State.stopped;
                    messagesTxt.text = "Game Over! Press Space to Restart";
                }
                break;

        }

    }
}
