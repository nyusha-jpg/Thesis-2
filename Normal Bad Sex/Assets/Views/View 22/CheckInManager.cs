using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class CheckInManager : MonoBehaviour
{
 
    public GameObject checkInButton;
    public GameObject speechBubble;
    public GameObject speechBubbleAnim;
    public bool isCurrentlyColliding;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("BJ Collision: " + isCurrentlyColliding);

        if (Input.GetMouseButtonDown(0) && (isCurrentlyColliding = true))
        {
            //Debug.Log("spacebar and collider");
            //bjSeen = true;

            
         


        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "CenterCollider")
        {
            isCurrentlyColliding = true;
            //Debug.Log(isCurrentlyColliding);
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
       isCurrentlyColliding = false;
        //Debug.Log(isCurrentlyColliding);
    }


}
