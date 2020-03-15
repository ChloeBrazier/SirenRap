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
    private int fadeIndex;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check fade timer
        if (fadeTick <= 1)
        {
            //increment fade tick
            fadeTick += Time.deltaTime / fadeTimer;
        }
        else
        {
            //enable tallying for the faded-in text
            if (fadeIndex != 0)
            {
                fadeList[fadeIndex - 1].GetComponent<TallyParent>().enabled = true;
            }

            //increment fade index
            fadeIndex++;

            //make sure not to go out of range
            if(fadeIndex <= fadeList.Count - 1)
            {
                //start fading in the next thing of text
                fadeList[fadeIndex].GetComponent<Text>().CrossFadeAlpha(1f, 1f, false);

                //reset fade timer
                fadeTick = 0f;
            }
        }
    }
}
