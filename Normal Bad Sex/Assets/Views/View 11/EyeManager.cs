using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class EyeManager : MonoBehaviour
{
    public GameObject eye;
    public Animator eyeAnim;
    public GameObject blowjob;
    public Animator blowjobAnim;
    public bool isCurrentlyColliding;

    // Start is called before the first frame update
    void Start()
    {
        eyeAnim = eye.GetComponent<Animator>();
        blowjobAnim = blowjob.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && (isCurrentlyColliding = true))
        {
            Debug.Log("spacebar and collider");
            blowjobAnim.enabled = false;
            eyeAnim.Play("EyeOpening");

        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isCurrentlyColliding = true;
        Debug.Log(isCurrentlyColliding);
    }

    void OnCollisionExit2D(Collision2D col)
    {
        isCurrentlyColliding = false;
        //Debug.Log(isCurrentlyColliding);
    }



}
