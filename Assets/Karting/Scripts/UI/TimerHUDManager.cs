﻿using System;
using UnityEngine;
using TMPro;

public class TimerHUDManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    TimeManager m_TimeManager;
    
    private void Start()
    {
        m_TimeManager = FindObjectOfType<TimeManager>();
        DebugUtility.HandleErrorIfNullFindObject<TimeManager, ObjectiveReachTargets>(m_TimeManager, this);


        if (m_TimeManager.IsFinite)
        {
            timerText.text = "";
        }
    }
    
    void Update()
    {
        if (m_TimeManager.IsFinite)
        {   
            timerText.gameObject.SetActive(true);
            int timePassed = (int) Math.Ceiling(m_TimeManager.TimePassed);
            timerText.text = string.Format("{0}:{1:00}", timePassed / 60, timePassed % 60);
        }
        else
        {
            timerText.gameObject.SetActive(false);
        }
    }
}
