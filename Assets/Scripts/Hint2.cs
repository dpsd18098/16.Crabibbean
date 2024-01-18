using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint2 : MonoBehaviour
{
    Animator hint2Anim;

    void Start()
    {
        hint2Anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
    public void Animate()
    {
        hint2Anim.Play("Hint3");
    }
}
