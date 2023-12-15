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

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        myState = State.stopped;
    }

    // Update is called once per frame
    void Update()
    {
        switch (myState) 
        {
            case State.stopped:
                if (Input.GetButtonDown("Space"))
                {
                    myState = State.playing;
                    time = 90;
                    messagesTxt.text = "";
                }
                break; 

            case State.playing:
                time -= Time.deltaTime;
                timeTxt.text = "Time:" + time.ToString("00.00");
                if (time < 0)
                {
                    myState = State.stopped;
                    messagesTxt.text = "Game Over! Press Space to Restart";
                }
                break;

        }

    }
}
