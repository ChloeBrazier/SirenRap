using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : TallyParent
{
    //text component
    private Text scoreText;

    //audio source for tally noise
    [SerializeField]
    private AudioSource tallyNoise;

    //timer and tick for ticking up score
    private float tallyTime = 2f;
    private float tallyTick;

    //value for score incrementation
    private float scoreIncrement;

    // Start is called before the first frame update
    void Start()
    {
        //save score text component
        scoreText = GetComponent<Text>();

        //save score increment
        scoreIncrement = tallyTime / GameObject.Find("Miss Box").GetComponent<HitManager>().playerScore;

        //play tally noise
        tallyNoise.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(tallyTick <= 1)
        {
            //increase score text value
            scoreText.text += scoreIncrement;
        }
        else
        {
            //stop the tally noise
            tallyNoise.Stop();

            //destroy this script
            Destroy(this);
        }

        //increment timer tick
        tallyTick += Time.deltaTime / tallyTime;
    }
}
