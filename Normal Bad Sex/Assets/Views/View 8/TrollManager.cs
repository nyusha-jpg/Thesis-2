using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollManager : MonoBehaviour
{
    public GameObject toy;
    public GameObject knob;
    public GameObject handReach;
    public GameObject trollReveal;
    // Start is called before the first frame update
    void Start()
    {
        handReach.SetActive(false);
        trollReveal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
