using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPulse : MonoBehaviour
{
    //list of colors to lerp between
    [SerializeField]
    private List<Color> colorList;

    //int for place in the color list
    private int colorIndex;

    //color change timer and tick
    private float changeTime = 4.0f;
    private float changeTick;

    //background color
    private Color initialColor;

    //next color
    private Color nextColor;

    //bools to check if the background color should change
    public bool isChanging = false;
    private bool loopChange = false;

    // Start is called before the first frame update
    void Start()
    {
        //save initial color
        initialColor = GetComponent<Camera>().backgroundColor;
    }

    // Update is called once per frame
    void Update()
    {
        //fade the mesage out
        if (changeTick <= 1 && isChanging == true)
        {
            //lerp sprite's transparencey to make it invisible
            GetComponent<Camera>().backgroundColor = Color.Lerp(GetComponent<Camera>().backgroundColor, nextColor, changeTick);

            //increment fadeTick
            changeTick += Time.deltaTime / changeTime;
        }
        else
        {
            //reset tick timer
            changeTick = 0f;

            //change changing bool to false
            isChanging = false;

            //check if loop bool is true
            if (loopChange == true)
            {
                //change the color again
                ChangeColor();
            }
        }
    }

    public void ChangeColor()
    {
        //increase color index
        colorIndex++;

        //check if it's greater than the number of colors
        if(colorIndex > (colorList.Count - 1))
        {
            //set index to 0
            colorIndex = 0;
        }

        //choose a next color from the color list
        nextColor = colorList[colorIndex];

        //set color change bools to true
        isChanging = true;
        loopChange = true;
    }

    public void ResetColor()
    {
        //set nextColor to initial background color
        nextColor = initialColor;

        //set color changing bool to true and loop to false
        isChanging = true;
        loopChange = false;
    }
}
