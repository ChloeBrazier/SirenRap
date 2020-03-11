using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour
{
    //input master
    private InputMaster controls;

    //the player's score
    private int playerScore;

    //queue of actionable beats
    private Queue<MusicBeat> playableNotes;

    //int for tracking consecutive hits
    private int comboScore;

    //radii for hit categories
    public float goodRadius;
    public float perfectRadius;

    private void Awake()
    {
        //initialize controls
        controls = new InputMaster();

        //hook up controls
        controls.Test.PressUp.started += context => CheckUp();
        controls.Test.PressDown.started += context => CheckDown();
        controls.Test.PressLeft.started += context => CheckLeft();
        controls.Test.PressRight.started += context => CheckRight();
    }

    // Start is called before the first frame update
    void Start()
    {
        //create playable notes queue
        playableNotes = new Queue<MusicBeat>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //TODO: check combo score and make the scene react accordingly
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //check if the object entering the trigger is a music beat
        if (collision.gameObject.GetComponent<MusicBeat>())
        {
            //add the beat to the queue
            playableNotes.Enqueue(collision.gameObject.GetComponent<MusicBeat>());
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        //check if the object exiting the trigger is a music beat
        if(playableNotes.Contains(collision.gameObject.GetComponent<MusicBeat>()))
        {
            //dequeue the beat
            playableNotes.Dequeue();

            //count the beat as a missed beat and drop the combo
            collision.gameObject.GetComponent<MusicBeat>().HitBeat(HitType.Miss);
        }
    }

    public void CheckBeatDistance(MusicBeat beat)
    {
        //store the distance between the beat and the center of the hitbox
        float beatDistance = Vector2.Distance(beat.gameObject.transform.position, transform.position);

        //check the distance to determine score
        if (beatDistance <= perfectRadius)
        {
            //hit the beat as a perfect note
            beat.HitBeat(HitType.Perfect);

            //add to score
            playerScore += 1000;

            //add to combo
            comboScore += 1;
            Debug.Log("Player Score: " + playerScore + "\nCombo Score: " + comboScore);
        }
        else if(beatDistance <= goodRadius)
        {
            //hit the beat as a good note
            beat.HitBeat(HitType.Good);

            //add to score
            playerScore += 500;

            //add to combo
            comboScore += 1;
            Debug.Log("Player Score: " + playerScore + "\nCombo Score: " + comboScore);
        }
        else
        {
            //miss the beat
            beat.HitBeat(HitType.Miss);

            //drop the combo
            comboScore = 0;
        }
    }

    public void CheckUp()
    {
        //check the currently playable beat to see if it's an up beat
        if(playableNotes.Count > 0)
        {
            MusicBeat currentBeat = playableNotes.Dequeue();

            //check if the beat type is up
            if(currentBeat.beatType == BeatType.Up)
            {
                //check beat distance if the type matches
                CheckBeatDistance(currentBeat);
            }
            else
            {
                //miss the beat
                currentBeat.HitBeat(HitType.Miss);
            }
        }
    }

    public void CheckDown()
    {
        //check the currently playable beat to see if it's a down beat
        if (playableNotes.Count > 0)
        {
            MusicBeat currentBeat = playableNotes.Dequeue();

            //check if the beat type is down
            if (currentBeat.beatType == BeatType.Down)
            {
                //check beat distance if the type matches
                CheckBeatDistance(currentBeat);
            }
            else
            {
                //miss the beat
                currentBeat.HitBeat(HitType.Miss);
            }
        }
    }

    public void CheckLeft()
    {
        //check the currently playable beat to see if it's a left beat
        if (playableNotes.Count > 0)
        {
            MusicBeat currentBeat = playableNotes.Dequeue();

            //check if the beat type is left
            if (currentBeat.beatType == BeatType.Left)
            {
                //check beat distance if the type matches
                CheckBeatDistance(currentBeat);
            }
            else
            {
                //miss the beat
                currentBeat.HitBeat(HitType.Miss);
            }
        }
    }

    public void CheckRight()
    {
        //check the currently playable beat to see if it's a right beat
        if (playableNotes.Count > 0)
        {
            MusicBeat currentBeat = playableNotes.Dequeue();

            //check if the beat type is right
            if (currentBeat.beatType == BeatType.Right)
            {
                //check beat distance if the type matches
                CheckBeatDistance(currentBeat);
            }
            else
            {
                //miss the beat
                currentBeat.HitBeat(HitType.Miss);
            }
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
