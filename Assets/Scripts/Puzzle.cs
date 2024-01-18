using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    Animator puzzleAnim;
    // Start is called before the first frame update
    void Start()
    {
        puzzleAnim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Animate()
    {
        puzzleAnim.Play("Hint1");
    }
}
