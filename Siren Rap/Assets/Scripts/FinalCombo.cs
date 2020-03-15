using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCombo : TallyParent
{
    //text component
    private Text comboText;

    //gameobject for next thing to activate
    [SerializeField]
    private GameObject nextActivated;

    //audio source for tally noise
    [SerializeField]
    private AudioSource tallyNoise;

    //value for combo incrementation and temp texrt
    private int tempText;
    private int comboIncrement = 2;

    // Start is called before the first frame update
    void Start()
    {
        //save score text component
        comboText = GetComponent<Text>();

        //play tally noise
        tallyNoise.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (tempText < GameObject.Find("Miss Box").GetComponent<HitManager>().highestCombo)
        {
            //increase score text value
            tempText += comboIncrement;
            comboText.text = "Highest Combo:    " + tempText;
        }
        else
        {
            //set combo text to exact combo
            comboText.text = "Highest Combo:    " + GameObject.Find("Miss Box").GetComponent<HitManager>().highestCombo;

            //stop the tally noise
            tallyNoise.Stop();

            //activate next gameobject's tally script
            nextActivated.GetComponent<TallyParent>().enabled = true;

            //destroy this script
            Destroy(this);
        }
    }
}
