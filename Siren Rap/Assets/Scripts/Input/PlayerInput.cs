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

    //bool to check if paused and changing time
    private bool paused = false;
    private bool changeTime = false;

    //timer for slowing down time when pausing
    private float pauseTime = 0.85f;
    private float pauseTick;

    //list of pause clips
    [SerializeField]
    private List<AudioClip> pauseClips;

    //audio source pitch and timescale increments
    private float pitchIncrement;
    private float timeScaleIncrement;

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
        //save audio source from song manager and its pitch increment for pausing
        song = songManager.GetComponent<AudioSource>();
        pitchIncrement = pauseTime / song.pitch;
    }

    // Update is called once per frame
    void Update()
    {
        //check if timescale is being changed
        if(changeTime == true && pauseTick <= 1)
        {
            //check if the game is paused
            if(paused)
            {
                //decrease audio pitch
                song.pitch *= pitchIncrement;
                if(song.pitch <= 0.01)
                {
                    song.pitch = 0;
                }

                //decrease time scale
                Time.timeScale *= timeScaleIncrement;
                if(Time.timeScale <= 0.01)
                {
                    Time.timeScale = 0;
                }
            }
            else
            {
                //increase audio pitch
                song.pitch += pitchIncrement;
                if (song.pitch >= 1)
                {
                    song.pitch = 1;
                }

                //increase time scale
                Time.timeScale += timeScaleIncrement;
                if (Time.timeScale >= 1)
                {
                    Time.timeScale = 1;
                }
            }

            //increment time tick
            pauseTick += Time.deltaTime / pauseTime;
        }
        else if(changeTime == false)
        {
            //save current timescale for timescale increment
            timeScaleIncrement = pauseTime / Time.timeScale;
        }
        else
        {
            //reset pause tick
            pauseTick = 0f;

            //set change time to false
            changeTime = false;
        }
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
        //switch pause action
        if(paused == true)
        {
            //play unpause clip
            AudioSource.PlayClipAtPoint(pauseClips[1], Camera.main.transform.position);

            //adjust pause settings
            paused = false;
            changeTime = true;
            controls.Test.Start.started -= ResetTime;
            controls.Test.Start.started += PauseLevel;
        }
        else
        {
            //reset time scale and audio pitch
            Time.timeScale = 1.0f;
            song.pitch = 1.0f;
        }
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

        //hook up pause event to start button
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
        //set paused bool to true
        paused = true;

        //set slowing time bool to true
        changeTime = true;

        //play pause clip
        AudioSource.PlayClipAtPoint(pauseClips[0], Camera.main.transform.position);

        //set timescale to 0
        //Time.timeScale = 0;

        //set pitch of audio components to 0
        //song.pitch = 0;

        //switch action to make it unpause level
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
