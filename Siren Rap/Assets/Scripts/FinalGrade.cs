using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalGrade : TallyParent
{
    //list of grade images
    [SerializeField]
    private List<Sprite> gradeList;

    //image component
    [SerializeField]
    private Image gradeImage;

    //timer and tick for ticking up score
    private float tallyTime = 2f;
    private float tallyTick;

    //final grade index int
    private int gradeIndex;

    // Start is called before the first frame update
    void Start()
    {
        //set grade index
        if(GameObject.Find("Miss Box").GetComponent<HitManager>().playerScore > 187150)
        {
            //set index for s rank
            gradeIndex = 0;
        }
        else if(GameObject.Find("Miss Box").GetComponent<HitManager>().playerScore > 177300)
        {
            //set index for a rank
            gradeIndex = 1;
        }
        else if (GameObject.Find("Miss Box").GetComponent<HitManager>().playerScore > 157600)
        {
            //set index for b rank
            gradeIndex = 2;
        }
        else if (GameObject.Find("Miss Box").GetComponent<HitManager>().playerScore > 137900)
        {
            //set index for c rank
            gradeIndex = 3;
        }
        else
        {
            //setindex for f rank
            gradeIndex = 4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (tallyTick <= 1)
        {
            //increment timer tick
            tallyTick += Time.deltaTime / tallyTime;
        }
        else
        {
            //TODO: add screen shake?

            //set grade image
            gradeImage.sprite = gradeList[gradeIndex];
        }
    }
}
