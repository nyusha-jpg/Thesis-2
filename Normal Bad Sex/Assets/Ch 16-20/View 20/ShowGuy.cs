using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGuy : MonoBehaviour
{

    public GameObject calling;
    public GameObject guy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        calling.SetActive(false);
        guy.SetActive(true);
    }
}
