using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint2 : MonoBehaviour
{
    Animator hint2Anim;
    // Start is called before the first frame update
    void Start()
    {
        hint2Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Animate()
    {
        hint2Anim.Play("Hint3");
    }
}
