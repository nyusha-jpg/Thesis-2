using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class ShowerManager : MonoBehaviour
{
    public GameObject[] clothing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D col)
    {

        //if all objects in array detect collision, play shower anim
        //Debug.Log("Collision detected");
    }
}
