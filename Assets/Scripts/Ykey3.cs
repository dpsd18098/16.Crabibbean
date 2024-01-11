using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ykey3 : MonoBehaviour
{
    Animator Key3Anim;

    // Start is called before the first frame update
    void Start()
    {
        Key3Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Animate()
    {
        Key3Anim.Play("Key3");
    }
}
