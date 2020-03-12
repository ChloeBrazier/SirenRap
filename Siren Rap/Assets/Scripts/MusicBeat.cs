using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BeatType
{ 
    Up,
    Down,
    Left,
    Right
}

//enum for hit type
public enum HitType
{
    Good,
    Perfect,
    Miss
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

    //bool to check if the beat is active or not
    private bool active = true;

    //fade timer and tick
    private float fadeTime = 0.3f;
    private float fadeTick;

    //beat sprite color and transparent color
    private Color beatColor;
    private Color transparent;

    //hit message prefab
    [SerializeField]
    private GameObject hitMessage;

    // Start is called before the first frame update
    void Start()
    {
        //save beat's sprite color and transparent color
        //beatColor = GetComponent<SpriteRenderer>().color;
        transparent = new Color(beatColor.r, beatColor.b, beatColor.b, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move to the right based on increment distance every frame
        if(active)
        {
            Vector3 tempPos = transform.position;
            tempPos.x += moveIncrement;
            transform.position = tempPos;
        }
        else
        {
            //fade the beat out
            if(fadeTick <= 1)
            {
                //lerp sprite's transparencey to make it invisible
                GetComponent<SpriteRenderer>().color = Color.Lerp(GetComponent<SpriteRenderer>().color, transparent, fadeTick);
                //GetComponent<Image>().color = Color.Lerp(GetComponent<Image>().color, transparent, fadeTick);
            }
            else
            {
                //destroy this beat
                Destroy(this.gameObject);
            }

            //increment fadeTick
            fadeTick += Time.deltaTime / fadeTime;
        }
    }

    public void SetMoveIncrement(float boxLocation, float time)
    {
        //set move distance and move time
        moveDistance = boxLocation - transform.position.x;
        Debug.Log("Move distance: " + moveDistance);
        moveTime = time;

        //set the distance to increment the beat by each frame
        moveIncrement = (moveDistance / moveTime) * Time.deltaTime;

        //debug move increment
        Debug.Log("move increment: " + moveIncrement);
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
                //GetComponent<Image>().sprite = typeSprites[0];
                break;
            case BeatType.Down:
                GetComponent<SpriteRenderer>().sprite = typeSprites[1];
                //GetComponent<Image>().sprite = typeSprites[1];
                break;
            case BeatType.Left:
                GetComponent<SpriteRenderer>().sprite = typeSprites[2];
                //GetComponent<Image>().sprite = typeSprites[2];
                break;
            case BeatType.Right:
                GetComponent<SpriteRenderer>().sprite = typeSprites[3];
                //GetComponent<Image>().sprite = typeSprites[3];
                break;
        }
    }

    public void HitBeat(HitType hitType)
    {
        //set active mode to false
        active = false;

        switch (hitType)
        {
            case HitType.Perfect:

                //spawn hit message with a type of perfect
                SpawnHitMessage(HitType.Perfect);

                break;
            case HitType.Good:

                //spawn hit message with a type of good
                SpawnHitMessage(HitType.Good);

                break;
            case HitType.Miss:

                //spawn hit message with a type of miss
                SpawnHitMessage(HitType.Miss);

                break;
        }
    }

    public void SpawnHitMessage(HitType type)
    {
        //spawn hit message and set its' type
        GameObject newMessage = Instantiate(hitMessage, transform.position, Quaternion.identity);
        newMessage.GetComponent<HitMessage>().SetMessageType(type);
        newMessage.transform.SetParent(transform);
    }
}
