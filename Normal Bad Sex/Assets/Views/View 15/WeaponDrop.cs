using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class WeaponDrop : MonoBehaviour
{
    //public GameObject thisWeapon;
    public float moveSpeed = 1.0f;
    public Vector2 targetPosition;


    // Start is called before the first frame update
    void Start()
    {
        //DOTween.Init();

    }

    // Update is called once per frame
    void Update()
    {

       transform.position = Vector3.Lerp(this.transform.position, targetPosition, Time.time);

        //new Vector2(moveSpeed * Time.deltaTime, targetPosition);
    }

}
