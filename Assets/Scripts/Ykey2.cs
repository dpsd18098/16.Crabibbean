using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ykey2 : MonoBehaviour
{
    Animator Key2Anim;
    // Start is called before the first frame update
    void Start()
    {
        Key2Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Animate()
    {
        Key2Anim.Play("Key2");
    }
}
