using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint1 : MonoBehaviour
{
    Animator hint1Anim;
    // Start is called before the first frame update
    void Start()
    {
        hint1Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Animate()
    {
        hint1Anim.Play("Hint2");
    }
}
