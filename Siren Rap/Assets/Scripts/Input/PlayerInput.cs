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

    //songmanager object
    [SerializeField]
    private GameObject songManager;

    private void Awake()
    {
        //initialize controls
        controls = new InputMaster();

        //hook up controls
        controls.Test.PressUp.started += context => SetUpBlock();
        controls.Test.PressUp.canceled += context => ResetUpBlock();
        controls.Test.PressDown.started += context => SetDownBlock();
        controls.Test.PressDown.canceled += context => ResetDownBlock();
        controls.Test.PressLeft.started += context => SetLeftBlock();
        controls.Test.PressLeft.canceled += context => ResetLeftBlock();
        controls.Test.PressRight.started += context => SetRightBlock();
        controls.Test.PressRight.canceled += context => ResetRightBlock();
        controls.Test.SpeedUp.performed += context => FastForward();
        controls.Test.SpeedUp.canceled += context => ResetTime();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FastForward()
    {
        //save speed scale
        float speedScale = 3.0f;
        
        //increase time scale
        Time.timeScale = speedScale;

        //increase audio pitch
        songManager.GetComponent<AudioSource>().pitch = speedScale;
    }

    public void ResetTime()
    {
        //reset time scale and audio pitch
        Time.timeScale = 1.0f;
        songManager.GetComponent<AudioSource>().pitch = 1.0f;
    }

    public void SetUpBlock()
    {
        //activate red sqaure
        redSquare.SetActive(true);

        //disable top square
        upSquare.SetActive(false);
    }

    public void ResetUpBlock()
    {
        //enable top black square
        upSquare.SetActive(true);

        //disable red square
        redSquare.SetActive(false);
    }

    public void SetDownBlock()
    {
        //active green sqaure
        greenSquare.SetActive(true);

        //disable bottom square
        downSquare.SetActive(false);
    }

    public void ResetDownBlock()
    {
        //enable bottom square
        downSquare.SetActive(true);

        //disable green square
        greenSquare.SetActive(false);
    }

    public void SetLeftBlock()
    {
        //activate purple sqaure
        purpleSquare.SetActive(true);

        //disable left square
        leftSquare.SetActive(false);
    }

    public void ResetLeftBlock()
    {
        //enable left black square
        leftSquare.SetActive(true);

        //disable purple square
        purpleSquare.SetActive(false);
    }

    public void SetRightBlock()
    {
        //activate blue sqaure
        blueSquare.SetActive(true);

        //disable right square
        rightSquare.SetActive(false);
    }

    public void ResetRightBlock()
    {
        //enable right square
        rightSquare.SetActive(true);

        //disable blue square
        blueSquare.SetActive(false);
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
