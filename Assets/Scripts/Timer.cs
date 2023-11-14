using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{   
    [Header("Component")]
    public Text timerText;
    [Header("Timer Settings")]
    public float currentTime;
    public bool countUp;
    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;
    [Header("Format Settings")]
    public bool hasFormat;
    public TimerFormats format;
    public Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();
    void Start()
    {
        timeFormats.Add(TimerFormats.Whole, "0");
        timeFormats.Add(TimerFormats.OneDecimal, "0.0");
        timeFormats.Add(TimerFormats.TwoDecimal, "0.00");
        timeFormats.Add(TimerFormats.ThreeDecimal, "0.000");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countUp ? currentTime += Time.deltaTime : currentTime -= Time.deltaTime;
        if(hasLimit && ((countUp && currentTime >= timerLimit) || (!countUp && currentTime <= timerLimit))) 
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false;
        }
        SetTimerText();
    }
    private void SetTimerText()
    {
        timerText.text = hasFormat ? currentTime.ToString(timeFormats[format]) : currentTime.ToString();
    }
}
public enum TimerFormats
{
    Whole,
    OneDecimal,
    TwoDecimal,
    ThreeDecimal,
}