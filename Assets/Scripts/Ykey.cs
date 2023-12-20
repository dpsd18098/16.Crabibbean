using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ykey : MonoBehaviour
{
    Animator KeyAnim;
    void Start()
    {
        KeyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void Animate()
    {
        KeyAnim.Play("KeyAnimation");
    }
}
