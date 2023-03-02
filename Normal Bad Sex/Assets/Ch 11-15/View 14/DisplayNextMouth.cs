using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DisplayNextMouth : MonoBehaviour
{
    public GameObject[] leftSmile;
    public int leftClicks;
    public bool leftFull;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (gameObject.tag == "LeftSmile")
                {
                    foreach (GameObject pic in leftSmile)
                    {
                        if (pic.active)
                        {
                            if (hit.collider == pic.GetComponent<Collider2D>() && (leftClicks < 3))
                            {
                                leftSmile[leftClicks].SetActive(false);
                                leftClicks++;
                                leftSmile[leftClicks].SetActive(true);
                                //Debug.Log("Unbox Clicks: " + leftClicks);
                            }

                            if (leftClicks == 2)
                            {
                                //Debug.Log("box open");
                                leftFull = true;
                                //flowchart.SetBooleanVariable(boxOpen) = true;
                                // flowchart.SetBooleanVariable("boxOpen", true);
                            }
                        }
                    }
                }
            }
        }
    }

  
}
