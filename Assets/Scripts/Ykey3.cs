using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ykey3 : MonoBehaviour
{
    Animator Key3Anim;

    void Start()
    {
        Key3Anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void Animate()
    {
        Key3Anim.Play("Key3");
    }
}
