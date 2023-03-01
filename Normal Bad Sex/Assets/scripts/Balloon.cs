using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    Animator balloon;

    void Start()
    {
        balloon = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (gameObject.tag == "Blue") ;
        {

            if (Input.GetMouseButtonDown(0))
            {
                balloon.Play("BlueB");
            }

        }
        if (gameObject.tag == "red") ;
        {

            if (Input.GetMouseButtonDown(0))
            {
                balloon.Play("redB");
            }
        }
        if (gameObject.tag == "green") ;
        {

            if (Input.GetMouseButtonDown(0))
            {
                balloon.Play("greenB");
            }
        }
        if (gameObject.tag == "Lgreen") ;
        {

            if (Input.GetMouseButtonDown(0))
            {
                balloon.Play("LgreenB");
            }
        }
        if (gameObject.tag == "yellow") ;
        {

            if (Input.GetMouseButtonDown(0))
            {
                balloon.Play("yellowB");
            }
        }
    }
}
