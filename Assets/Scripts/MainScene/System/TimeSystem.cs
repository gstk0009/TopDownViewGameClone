using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour
{
    private Text time;

    private void Awake()
    {
        time = GetComponent<Text>();
    }

    private void Update()
    {
        time.text = DateTime.Now.ToString(("HH:mm"));
    }
}
