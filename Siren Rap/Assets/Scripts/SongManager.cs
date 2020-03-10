using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    //Dictionary of beats used for the song (easy mode)
    [Tooltip ("These are the beats for easy mode, with the float representing the time in seconds into the game that the beat will spawn")]
    public Dictionary<BeatType,float> easyBeats;

    [Tooltip("These are the beats for normal mode, with the float representing the time in seconds into the game that the beat will spawn")]
    public Dictionary<BeatType, float> normalBeats;

    [Tooltip("These are the beats for hard mode, with the float representing the time in seconds into the game that the beat will spawn")]
    public Dictionary<BeatType, float> hardBeats;

    //the player's score
    private int playerScore;

    //the audio source for the level's song
    private AudioSource levelSong;

    //queue of actionable beats
    private Queue<MusicBeat> playableNotes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //spawn notes 
    }
}
