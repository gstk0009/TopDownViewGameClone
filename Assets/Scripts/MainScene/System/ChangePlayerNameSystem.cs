using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerNameSystem : MonoBehaviour
{
    Text playerName;

    private void Awake()
    {
        playerName = GetComponent<Text>();
    }

    public void ChangeName()
    {
        if (PlayerNameInputSystem.isPossiblePlayerName)
        {
            playerName.text = PlayerNameInputSystem.InputPlayerName;
        }
    }
}
