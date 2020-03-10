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

    //array of beat sprites for beat types
    public Sprite[] typeSprites;

    //the distance the beat will move from its' spawn point to the end point
    public float moveDistance;

    //the time it will take tehe beat to reach the end of the tail
    public float moveTime;

    //the amount of distance to increment the beat by each frame
    private float moveIncrement;

    // Start is called before the first frame update
    void Start()
    {
        SetMoveIncrement(15.3f, 5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move to the right based on increment distance every frame
        Vector3 tempPos = transform.position;
        tempPos.x += moveIncrement;
        transform.position = tempPos;
    }

    public void SetMoveIncrement(float distance, float time)
    {
        //set move distance and move time
        moveDistance = distance;
        moveTime = time;

        //set the distance to increment the beat by each frame
        moveIncrement = (moveDistance / moveTime) * Time.deltaTime;
    }

    public void SetBeatType(BeatType type)
    {
        //set internal beat type to passed-in type
        beatType = type;

        //change sprite to match beat type
        switch(beatType)
        {
            case BeatType.Up:
                GetComponent<SpriteRenderer>().sprite = typeSprites[0];
                break;
            case BeatType.Down:
                GetComponent<SpriteRenderer>().sprite = typeSprites[1];
                break;
            case BeatType.Left:
                GetComponent<SpriteRenderer>().sprite = typeSprites[2];
                break;
            case BeatType.Right:
                GetComponent<SpriteRenderer>().sprite = typeSprites[3];
                break;
        }
    }
}
