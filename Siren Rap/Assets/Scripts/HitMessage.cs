using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMessage : MonoBehaviour
{
    //fade timer and tick
    private float fadeTime = 1.0f;
    private float fadeTick;

    //message sprite color and transparent color
    private Color messageColor;
    private Color transparent;

    //array of hit message sprites
    public Sprite[] typeSprites;

    //message type variable
    private HitType messageType;

    // Start is called before the first frame update
    void Start()
    {
        //save beat's sprite color and transparent color
        //messageColor = GetComponent<SpriteRenderer>().color;
        transparent = new Color(messageColor.r, messageColor.b, messageColor.b, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //move message up
        Vector3 tempPos = transform.position;
        tempPos.y += 1.0f * Time.deltaTime;
        transform.position = tempPos;

        //fade the mesage out
        if (fadeTick <= 1)
        {
            //lerp sprite's transparencey to make it invisible
            GetComponent<SpriteRenderer>().color = Color.Lerp(GetComponent<SpriteRenderer>().color, transparent, fadeTick);
        }
        else
        {
            //destroy the hit message after it fades out
            Destroy(this.gameObject);
        }

        //increment fadeTick
        fadeTick += Time.deltaTime / fadeTime;
    }

    public void SetMessageType(HitType type)
    {
        //set internal beat type to passed-in type
        messageType = type;

        //change sprite to match beat type
        switch (messageType)
        {
            case HitType.Miss:
                GetComponent<SpriteRenderer>().sprite = typeSprites[0];
                break;
            case HitType.Perfect:
                GetComponent<SpriteRenderer>().sprite = typeSprites[1];
                break;
            case HitType.Good:
                GetComponent<SpriteRenderer>().sprite = typeSprites[2];
                break;
        }
    }
}
