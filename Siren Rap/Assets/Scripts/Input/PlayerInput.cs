using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    //input master
    private InputMaster controls;

    //colored squares for input testing
    public GameObject redSquare;
    public GameObject blueSquare;
    public GameObject purpleSquare;
    public GameObject greenSquare;

    //pre-placed squares for input testing
    public GameObject upSquare;
    public GameObject downSquare;
    public GameObject leftSquare;
    public GameObject rightSquare;

    private void Awake()
    {
        //initialize controls
        controls = new InputMaster();

        //hook up controls
        controls.Test.Movement.started += context => SetBlock(context.ReadValue<Vector2>());
        controls.Test.Movement.canceled += context => ResetBlock(context.action.activeControl.displayName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBlock(Vector2 blockDirection)
    {
        if(blockDirection.x < 0)
        {
            //replace left black square with purple sqaure
            Instantiate(purpleSquare, leftSquare.transform.position, Quaternion.identity);

            //disable left square
            leftSquare.SetActive(false);

        }
        else if(blockDirection.x > 0)
        {
            //replace right black square with blue sqaure
            Instantiate(blueSquare, rightSquare.transform.position, Quaternion.identity);

            //disable right square
            rightSquare.SetActive(false);
        }
        else if(blockDirection.y > 0)
        {
            //replace top black square with red sqaure
            Instantiate(redSquare, upSquare.transform.position, Quaternion.identity);

            //disable top square
            upSquare.SetActive(false);
        }
        else if(blockDirection.y < 0)
        {
            //replace bottom black square with green sqaure
            Instantiate(greenSquare, downSquare.transform.position, Quaternion.identity);

            //disable bottom square
            downSquare.SetActive(false);
        }
    }

    public void ResetBlock(string pressedButton)
    {
        Debug.Log("ToString contents: " + pressedButton);

        if(pressedButton.Contains("Up"))
        {
            //enable top black square
            upSquare.SetActive(true);
        }
        else if(pressedButton.Contains("Left"))
        {
            //enable left black square
            leftSquare.SetActive(true);
        }
        else if (pressedButton.Contains("Right"))
        {
            //enable right square
            rightSquare.SetActive(true);
        }
        else if (pressedButton.Contains("Down"))
        {
            //enable right square
            downSquare.SetActive(true);
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
