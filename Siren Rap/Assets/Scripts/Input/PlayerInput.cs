using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    private AudioSource song;

    //start screen text
    [SerializeField]
    private Text startText;

    private void Awake()
    {
        //initialize controls
        controls = new InputMaster();

        //enable actions
        controls.Test.Enable();

        //hook up controls
        controls.Test.PressUp.started += SetUpBlock;
        controls.Test.PressUp.canceled += ResetUpBlock;
        controls.Test.PressDown.started += SetDownBlock;
        controls.Test.PressDown.canceled += ResetDownBlock;
        controls.Test.PressLeft.started += SetLeftBlock;
        controls.Test.PressLeft.canceled += ResetLeftBlock;
        controls.Test.PressRight.started += SetRightBlock;
        controls.Test.PressRight.canceled += ResetRightBlock;
        controls.Test.SpeedUp.performed += FastForward;
        controls.Test.SpeedUp.canceled += ResetTime;
        controls.Test.Start.started += StartSong;
        controls.Test.Reload.started += Reload;
        controls.Test.Quit.started += QuitGame;
    }

    private void Start()
    {
        //save audio source from song manager
        song = songManager.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FastForward(InputAction.CallbackContext ctx)
    {
        //save speed scale
        float speedScale = 3.0f;
        
        //increase time scale
        Time.timeScale = speedScale;

        //increase audio pitch
        song.pitch = speedScale;
    }

    public void ResetTime(InputAction.CallbackContext ctx)
    {
        //reset time scale and audio pitch
        Time.timeScale = 1.0f;
        song.pitch = 1.0f;

        //switch pause action
        controls.Test.Start.started -= ResetTime;
        controls.Test.Start.started += PauseLevel;
    }

    public void StartSong(InputAction.CallbackContext ctx)
    {
        //start the level by playing the song and saving the time it starts
        song.Play();
        songManager.GetComponent<SongTracker>().songTime = (float) AudioSettings.dspTime;

        //set level start bool to true
        songManager.GetComponent<SongManager>().levelStart = true;

        //disable start screen text
        startText.enabled = false;

        //prevent the level from being restarted by pressing start again
        controls.Test.Start.started -= StartSong;

        //TODO: hook up pause event to start button
        controls.Test.Start.started += PauseLevel;
    }

    public void Reload(InputAction.CallbackContext ctx)
    {
        //reload the scene when the button is pressed
        SceneManager.LoadScene(0);
    }

    public void Reload()
    {
        //reload the scene when the button is pressed
        SceneManager.LoadScene(0);
    }

    public void PauseLevel(InputAction.CallbackContext ctx)
    {
        //set timescale to 0
        Time.timeScale = 0;

        //set pitch of audio components to 0
        song.pitch = 0;

        //switch action to unpause level
        controls.Test.Start.started -= PauseLevel;
        controls.Test.Start.started += ResetTime;
    }

    public void QuitGame(InputAction.CallbackContext ctx)
    {
        Application.Quit();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetUpBlock(InputAction.CallbackContext ctx)
    {
        //activate red sqaure
        redSquare.SetActive(true);

        //disable top square
        upSquare.SetActive(false);
    }

    public void ResetUpBlock(InputAction.CallbackContext ctx)
    {
        //enable top black square
        upSquare.SetActive(true);

        //disable red square
        redSquare.SetActive(false);
    }

    public void SetDownBlock(InputAction.CallbackContext ctx)
    {
        //active green sqaure
        greenSquare.SetActive(true);

        //disable bottom square
        downSquare.SetActive(false);
    }

    public void ResetDownBlock(InputAction.CallbackContext ctx)
    {
        //enable bottom square
        downSquare.SetActive(true);

        //disable green square
        greenSquare.SetActive(false);
    }

    public void SetLeftBlock(InputAction.CallbackContext ctx)
    {
        //activate purple sqaure
        purpleSquare.SetActive(true);

        //disable left square
        leftSquare.SetActive(false);
    }

    public void ResetLeftBlock(InputAction.CallbackContext ctx)
    {
        //enable left black square
        leftSquare.SetActive(true);

        //disable purple square
        purpleSquare.SetActive(false);
    }

    public void SetRightBlock(InputAction.CallbackContext ctx)
    {
        //activate blue sqaure
        blueSquare.SetActive(true);

        //disable right square
        rightSquare.SetActive(false);
    }

    public void ResetRightBlock(InputAction.CallbackContext ctx)
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
