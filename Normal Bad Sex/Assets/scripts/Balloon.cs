using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    Animator BlueBalloon;

    void Start()
    {
        BlueBalloon = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BlueBalloon.Play("BlueB");
        }
    }
}
