using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint1 : MonoBehaviour
{
    Animator hint1Anim;

    void Start()
    {
        hint1Anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
    public void Animate()
    {
        hint1Anim.Play("Hint2");
    }
}
