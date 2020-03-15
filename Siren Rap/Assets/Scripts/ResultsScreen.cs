using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsScreen : MonoBehaviour
{
    //list of gameobjects to fade in
    [SerializeField]
    private List<GameObject> fadeList;

    //tick for fading things in
    private float fadeTimer = 1.0f;
    private float fadeTick;

    //fade index
    private int fadeIndex = 0;

    //opaque color
    private Color opaque;

    // Start is called before the first frame update
    void Start()
    {
        //save opaque color of first object in fadelist
        opaque = new Color(fadeList[fadeIndex].GetComponent<Text>().color.r, fadeList[fadeIndex].GetComponent<Text>().color.g, fadeList[fadeIndex].GetComponent<Text>().color.b, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //check fade timer
        if (fadeTick <= 1)
        {
            //lerp transparency of current fading object
            fadeList[fadeIndex].GetComponent<Text>().color = Color.Lerp(fadeList[fadeIndex].GetComponent<Text>().color, opaque, fadeTick);

            //increment fade tick
            fadeTick += Time.deltaTime / fadeTimer;
        }
        else
        {
            if(fadeIndex < fadeList.Count - 1)
            {
                //check if this is the first object to be lerped
                if(fadeIndex == 0)
                {
                    fadeList[fadeIndex].GetComponent<TallyParent>().enabled = true;
                }

                //increment fade index
                fadeIndex++;

                //start fading in the next thing of text
                opaque = new Color(fadeList[fadeIndex].GetComponent<Text>().color.r, fadeList[fadeIndex].GetComponent<Text>().color.g, fadeList[fadeIndex].GetComponent<Text>().color.b, 1f);

                //reset fade timer
                fadeTick = 0f;
            }
            else
            {
                Destroy(this);
            }
        }
    }
}
