using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCombo : TallyParent
{
    //text component
    private Text comboText;

    //audio source for tally noise
    [SerializeField]
    private AudioSource tallyNoise;

    //timer and tick for ticking up score
    private float tallyTime = 2f;
    private float tallyTick;

    //value for combo incrementation
    private float comboIncrement;

    // Start is called before the first frame update
    void Start()
    {
        //save score text component
        comboText = GetComponent<Text>();

        //save score increment
        comboIncrement = tallyTime / GameObject.Find("Miss Box").GetComponent<HitManager>().highestCombo;

        //play tally noise
        tallyNoise.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (tallyTick <= 1)
        {
            //increase score text value
            comboText.text += comboIncrement;
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
