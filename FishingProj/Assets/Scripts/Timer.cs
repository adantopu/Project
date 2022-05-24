using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool catchPrize = false;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        float t = Time.time - startTime;

        string seconds = (t % 60).ToString("f0");
        
        timerText.text = seconds + " seconds to catch";
    }

}
