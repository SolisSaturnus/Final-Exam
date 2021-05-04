using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float timeRemaining;
    public Text timeLeft;


    void Start()
    {
        timeRemaining = PlayerPrefs.GetFloat("time");


        timeLeft.text = "time remaining: " + timeRemaining.ToString("F2");
    }



    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            timeLeft.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            SceneManager.LoadScene("3Exit");
        }
    }
}
