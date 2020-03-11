﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{
    //list of beats used for the song
    [Tooltip("These are the beats for normal mode, with beat type respresnting the input the player must make to hit the beat")]
    public List<BeatType> beatList;

    //music beat prefab to spawn
    public GameObject musicBeat;

    //list of beat times
    [Tooltip("This is the time at which each beat appears, with the float representing the time in seconds into the game that the beat will spawn")]
    public List<float> timeList;

    //float for tracking the next time to spawn a beat
    private float nextSpawnTime;

    //transform for beat spawn
    public Transform beatSpawn;

    //the audio source for the level's song
    private AudioSource levelSong;

    //float for tracking level time
    private float levelTime;

    // Start is called before the first frame update
    void Start()
    {
        //TODO: start playing the level song
        levelSong = GetComponent<AudioSource>();
        levelSong.Play();

        //set the first spawn time
        nextSpawnTime = timeList[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //spawn notes when their time comes up
        if(levelTime >= nextSpawnTime)
        {
            //spawn new beat
            GameObject newBeat = Instantiate(musicBeat, beatSpawn.position, Quaternion.identity);

            //set beat type
            newBeat.GetComponent<MusicBeat>().SetBeatType(beatList[0]);

            //set beat list and next beat time values
            beatList.RemoveAt(0);
            timeList.RemoveAt(0);

            if(timeList.Count != 0)
            {
                nextSpawnTime = timeList[0];
            }
            else
            {
                //reset level time
                levelTime = 0f;

                //TODO: end the song
            }
            
        }

        //increase level time if there are more notes to spawn
        if(beatList.Count > 0)
        {
            levelTime += Time.deltaTime;
        }
    }
}