using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BeatType
{ 
    Up,
    Down,
    Left,
    Right
}

public class MusicBeat : MonoBehaviour
{
    //the type of beat this beat is
    public BeatType beatType;

    //the distance the beat will move from its' spawn point to the end point
    public float moveDistance;

    //the time it will take tehe beat to reach the end of the tail
    public float moveTime;

    //the amount of distance to increment the beat by each frame
    private float moveIncrement;

    // Start is called before the first frame update
    void Start()
    {
        //set the distance to increment the beat by each frame
        moveIncrement = (moveDistance / moveTime) * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move to the right based on increment distance every frame
        Vector3 tempPos = transform.position;
        tempPos.x += moveIncrement;
        transform.position = tempPos;
    }
}
