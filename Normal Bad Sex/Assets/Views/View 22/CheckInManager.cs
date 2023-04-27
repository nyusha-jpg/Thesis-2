using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Fungus;
using Debug = UnityEngine.Debug;
using Collision2D = UnityEngine.Collision2D;

public class CheckInManager : MonoBehaviour
{

    public Flowchart flowchart;

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
        
            Debug.Log("on green");
            flowchart.SetBooleanVariable("CheckGreen", true);
        
            

    }

    public void OnCollisionExit2D(Collision2D coll)
    {
        Debug.Log("off green");
        flowchart.SetBooleanVariable("CheckGreen", false);
        
    }


}
