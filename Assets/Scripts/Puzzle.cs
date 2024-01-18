using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    Animator puzzleAnim;

    void Start()
    {
        puzzleAnim = GetComponent<Animator>(); 
    }

    void Update()
    {
        
    }
    public void Animate()
    {
        puzzleAnim.Play("Hint1");
    }
}
