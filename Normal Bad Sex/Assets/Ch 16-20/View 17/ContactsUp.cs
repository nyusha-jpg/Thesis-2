using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Collections.Specialized;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ContactsUp : MonoBehaviour
{
    public GameObject contactsList;
    public Vector3 currentPosition;
    public float deltaY = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("button click script exists");
        currentPosition = contactsList.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Boolean up)
    {
       Debug.Log("clicked");
        if (!up) deltaY *= -1;
        else;

        contactsList.transform.position = new Vector3(contactsList.transform.position.x, 
                                                     (contactsList.transform.position.y + deltaY), 
                                                      contactsList.transform.position.z);
        
    }

}
