using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TallyParent : MonoBehaviour
{
    //save hit box object
    protected HitManager scoreObject;

    // Start is called before the first frame update
    void Start()
    {
        scoreObject = GameObject.Find("Miss Box").GetComponent<HitManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
