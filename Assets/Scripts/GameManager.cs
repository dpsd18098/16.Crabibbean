using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timeTxt;
    public TextMeshProUGUI messagesTxt;
    public TextMeshProUGUI messagesTxtMinusTime;

    float time = 180;

    public static GameManager instance;

    public enum State { stopped, playing}
    public State myState;

    void Start()
    {
        instance = this;
        myState = State.stopped;
    }

    public void PlayPuzzle()
    {
        GameObject.Find("Puzzle").GetComponent<Animator>().enabled = true;
    }
    void Update()
    {
        switch (myState) 
        {
            case State.stopped:
                if (Input.GetButtonDown("Fire1")) 
                {
                    myState = State.playing;
                    time = 180;
                    messagesTxt.text = "";

                    Invoke(nameof(PlayPuzzle), 0.5f);
                }
                break;

            case State.playing:
                time -= Time.deltaTime;
                timeTxt.text = "" + time.ToString("00.00");
                if (time < 0)
                {
                    myState = State.stopped;
                    messagesTxt.text = "Game Over! Click to restart.";
                }
                break;
        }
    }
    public void MinusTime()
    {
        time -= 3;
        timeTxt.text = "";
        messagesTxtMinusTime.text = "Wrong object, -3s";
        Invoke(nameof(DestroyTxt), 2);
    }

    public void DestroyTxt()
    {
        messagesTxtMinusTime.text = "";
    }

    public void StopTime()
    {
        time = 0;
        timeTxt.text = "" + time.ToString("00.00");
        myState = State.stopped;
    }

    //prospathia na pataei to ctrl gia na xanadei ton papiro, alla den paizei
    //public void Hints()
    //{
        //int hint = Random.Range(1, 4);
        //switch (hint)
        //{
            //case 1:
                //GameObject.Find("Puzzle").GetComponent<Puzzle>().Animate();
                //break;

            //case 2:
                //GameObject.Find("Hint1").GetComponent<Hint1>().Animate();
                //break;

            //case 3:
                //GameObject.Find("Hint2").GetComponent<Hint2>().Animate();
                //break;

            //default:
                //break;
        //}
    //}
}
