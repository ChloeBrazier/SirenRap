using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPulse : MonoBehaviour
{
    //list of colors to lerp between
    [SerializeField]
    private List<Color> colorList;

    //color change timer and tick
    private float changeTime = 0.5f;
    private float changeTick;

    //background color
    private Color initialColor;

    //next color
    private Color nextColor;

    //bool to check if the background color should change
    private bool isChanging = false;

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
        }
    }

    public void ChangeColor()
    {
        //choose a random color from the color list
        int randInt = Random.Range(0, colorList.Count);
        nextColor = colorList[randInt];

        //set color change bool to true
        isChanging = true;
    }

    public void ResetColor()
    {
        //set nextColor to initial background color
        nextColor = initialColor;

        //set color changing bool to true
        isChanging = true;
    }
}
