using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    float _timer;
    public TextMeshProUGUI timerText;
    public int countDown = 10; // countdown time is adjustable
    bool stopTimer;

    public event EventHandler WhenTimeIsUp;

    // Start is called before the first frame update
    void Start()
    {
        _timer = Time.time;
        countDown++;
    }
    // Update is called once per frame
    void Update()
    {
        if (_timer < Time.time && !stopTimer) // compares _time value with Time.time of the game
        {
            if (countDown > 0)
            {
                countDown -= 1; // deduct 1 second form countdown time
                timerText.text = "Time Left: " + countDown.ToString(); 
            }
            if (countDown == 0)
            {
                timerText.text = "Out of Time! ";
                WhenTimeIsUp?.Invoke(this, EventArgs.Empty); // invokes the WhenTimeIsUp event
                stopTimer = true; // this stops the timer. it stops counting
            }
            _timer = Time.time + 1; // increments time by 1 second
        }
    }
}
