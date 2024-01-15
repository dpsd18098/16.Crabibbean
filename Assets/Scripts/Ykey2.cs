using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ykey2 : MonoBehaviour
{
    Animator Key2Anim;

    void Start()
    {
        Key2Anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void Animate()
    {
        Key2Anim.Play("Key2");
    }
}
