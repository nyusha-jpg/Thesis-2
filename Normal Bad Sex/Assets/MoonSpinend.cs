using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonSpinend : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        anim.Play("eomg anim");
    }
}