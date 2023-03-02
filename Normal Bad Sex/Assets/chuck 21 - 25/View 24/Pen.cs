using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class Pen : MonoBehaviour
{
   // GameManager myManager; //manager ref
    public Collider2D penCol; //saving the collider

    #region StateDeclartion
    [HideInInspector]
    public enum State //creating an enumeration of all the states we possess
    {
        Untouched,
        PickedUp,
        Drawing
    }

    private State _currentState; //this is our protection level that also states runs the "one-time" state switcher
    public State CurrentState
    {
        get
        {
            return _currentState;
        }
        set
        {
            _currentState = value;
            TransitionStates(value);
        }
    }
    #endregion

    //I need to have multiple rotation position to jump between depending on the pen state
    private Vector3 defaultEulerAngles; //saving the deafult rot
    private Vector3 pickedUpEulerAngles = new Vector3(0f, 0f, -20f); //for the picked up state
    private Vector3 drawingEulerAngles = new Vector3(0f, 0f, 0f); //drawing state
    private Vector3 defaultPos; //also pos! I need only the default though

    private void TransitionStates(State newState) // one-time state changer
    {
        switch (newState)
        {
            case State.Untouched: //this is when the pen is just laying on the table
                //penSprite.sortingOrder = -3;
                //GameManager.AllowDraw = false; //no drawing when the pen is not picked up!
               // myManager.ballotPanel.GetComponent<BoxCollider2D>().enabled = true; //also this? is done to switch between ballot colliders (the thing I was asking you in class!)
                transform.eulerAngles = defaultEulerAngles; //resetting the rotation
                transform.position = defaultPos; //and position
                penCol.enabled = true; //returning the collision so we can pick the pen up again
                break;

            case State.PickedUp:
                //penSprite.sortingOrder = 0;
               // myManager.ballotPanel.GetComponent<BoxCollider2D>().enabled = false; //same!
                //GameManager.AllowDraw = true; //and we can draw now
                transform.eulerAngles = pickedUpEulerAngles; //changing the rotation
                penCol.enabled = false; //as soon as we pick the pen up we disable it's collider so it doesn't collide with ballot colliders
                break;

            case State.Drawing:
                transform.eulerAngles = drawingEulerAngles; //new rotation
                penCol.enabled = false; //and doing that also? for some reason? just in case
                break;
            default:
                //Debug.Log("default state");
                break;
        }
    }
    private void RunStates() //updated state switcher
    {
        switch (CurrentState)
        {
            case State.PickedUp: //this state happens when we pick the pen up and just move it with the mouse pos
                MoveWithMouse(transform, new Vector3(0f, 0f, transform.position.z));
                break;
            case State.Drawing: //same, but it's a different state because of the one-time states and I need to continue updating the pos
                MoveWithMouse(transform, new Vector3(0f, 0f, transform.position.z));
                break;
            default:
                //Debug.Log("default state");
                break;
        }
    }

    void Start() //just setting the variabes
    {
        defaultEulerAngles = transform.eulerAngles;
        defaultPos = transform.position;
        CurrentState = State.Untouched;
        //penCol = GetComponent<PolygonCollider2D>();
    }

    void Update()
    {
        Debug.Log("hewwo");
        InputChecker(); //we can start checking for input
        RunStates(); //and run update states
    }

    void InputChecker()
    {
        Collider2D col = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)); //checking raycast

        if (col != null)
        {
            if (col.gameObject.tag == "Pen") //if we hit the pen 
            {
                if (Input.GetMouseButtonDown(0)) // and click it
                {
                    CurrentState = State.PickedUp; //the pen is picked up
                }
            }
        }
        else

        if (Input.GetMouseButtonDown(0))
        {
            CurrentState = State.Untouched; //putting the pen back on its place
        }

        if (Input.GetMouseButtonUp(0) && CurrentState == State.Drawing) //if we were previosly drawing
        {
            CurrentState = State.PickedUp; //we are going to the picked up state instead of the untouched state
        }

    }

    void MoveWithMouse(Transform objectToMove, Vector3 offset) //this function drags the object with along with the mouse
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        mousePos = Camera.main.ScreenToWorldPoint(mousePos) - offset;
        objectToMove.position = new Vector3(mousePos.x, mousePos.y, 0f);
    }
}

