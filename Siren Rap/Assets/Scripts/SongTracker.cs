using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongTracker : MonoBehaviour
{
    //bpm of the song being played
    [SerializeField]
    private float beatsPerMinute;

    //seconds per song beat
    private float secPerBeat;

    //current position of the song in seconds and beats
    private float songPosition;
    private float songPositionBeats;

    //the seconds that've passed since the song started
    public float songTime;

    //the audio source that's playing music
    private AudioSource song;

    //counter for beats based on integers
    private int beatCounter;

    // Start is called before the first frame update
    void Start()
    {
        //save the audio source
        song = GetComponent<AudioSource>();

        //get the seconds per beat
        secPerBeat = 60f / beatsPerMinute;
    }

    // Update is called once per frame
    void Update()
    {
        //check if the song is playing
        if(song.isPlaying == true)
        {
            //get song position in seconds
            songPosition = (float)AudioSettings.dspTime - songTime;

            //get song position in beats
            songPositionBeats = songPosition / secPerBeat;
        }

        //check beat count and make things in the scene react accordingly
        if(songPositionBeats >= beatCounter)
        {
            //start changing the background depending on combo score
            if(GetComponent<SongManager>().hitBox.GetComponent<HitManager>().comboScore % 2 == 0 && Camera.main.GetComponent<BackgroundPulse>().isChanging != true)
            {
                //check if the combo score is high enough
                if(GetComponent<SongManager>().hitBox.GetComponent<HitManager>().comboScore >= 10)
                {
                    Camera.main.GetComponent<BackgroundPulse>().ChangeColor();
                }
            }

            //increment beat counter
            beatCounter++;
        }
    }
}
