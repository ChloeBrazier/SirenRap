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
        //calculate the final score
        int finalGrade = CalculateGrade(GameObject.Find("Miss Box").GetComponent<HitManager>().playerScore, GameObject.Find("Miss Box").GetComponent<HitManager>().highestCombo);

        //set grade index
        if(finalGrade >= 9)
        {
            //set index for s rank
            gradeIndex = 0;
        }
        else if(finalGrade >= 8)
        {
            //set index for a rank
            gradeIndex = 1;
        }
        else if (finalGrade >= 6)
        {
            //set index for b rank
            gradeIndex = 2;
        }
        else if (finalGrade >= 4)
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
        //set grade image
        gradeImage.sprite = gradeList[gradeIndex];
    }

    public int CalculateGrade(float finalScore, float highestCombo)
    {
        //temporary int to store final grade score
        int gradeScore = 0;

        //check highest combo and add to grade score
        if (highestCombo >= 50)
        {
            //add 3 points to final grade
            gradeScore += 3;
        }
        else if(highestCombo >= 30)
        {
            //add 2 points to final grade
            gradeScore += 2;
        }
        else if(highestCombo >= 10)
        {
            //add 1 point to final grade
            gradeScore++;
        }

        //store division of final score
        float scoreDivision = (GameObject.Find("GameManager").GetComponent<SongManager>().beatNumber * 1000) / 6;

        //check final score and add to grade score
        if(finalScore >= (scoreDivision * 5))
        {
            //add 7 points to final grade
            gradeScore += 7;
        }
        else if(finalScore >= (scoreDivision * 4))
        {
            //add 6 points to final grade
            gradeScore += 6;
        }
        else if (finalScore >= (scoreDivision * 3))
        {
            //add 5 points to final grade
            gradeScore += 5;
        }
        else if (finalScore >= (scoreDivision * 2))
        {
            //add 1 point to final grade
            gradeScore++;
        }


        return gradeScore;
    }
}
