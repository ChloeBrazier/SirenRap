using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : TallyParent
{
    //text component
    private Text scoreText;

    //gameobject for next thing to activate
    [SerializeField]
    private GameObject nextActivated;

    //audio source for tally noise
    [SerializeField]
    private AudioSource tallyNoise;

    //value for score incrementation and temp text
    private int tempText;
    private int scoreCheck;
    private int scoreIncrement = 1111;

    // Start is called before the first frame update
    void Start()
    {
        //save score text component
        scoreText = GetComponent<Text>();

        //play tally noise
        tallyNoise.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(tempText < GameObject.Find("Miss Box").GetComponent<HitManager>().playerScore)
        {
            //increase score text value
            tempText += scoreIncrement;
            scoreText.text = "Final Score:    " + tempText;
        }
        else
        {
            //set score text to exact score
            scoreText.text = "Final Score:    " + GameObject.Find("Miss Box").GetComponent<HitManager>().playerScore;

            //stop the tally noise
            tallyNoise.Stop();

            //activate next gameobject's tally script
            nextActivated.GetComponent<TallyParent>().enabled = true;

            //destroy this script
            Destroy(this);
        }
    }
}
