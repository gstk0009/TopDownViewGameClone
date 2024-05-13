using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerNameSystem : MonoBehaviour
{
    private Text PlayerName;

    private void Awake()
    {
        PlayerName = GetComponent<Text>();
    }

    public void ChangeName()
    {
        if (PlayerNameInputSystem.isPossiblePlayerName)
        {
            PlayerName.text = PlayerNameInputSystem.InputPlayerName;
        }
    }
}
