using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameInputSystem : MonoBehaviour
{
    public static bool isPossiblePlayerName;
    public static string InputPlayerName;
    private TMP_InputField playerName;

    private void Awake()
    {
        playerName = GetComponent<TMP_InputField>();
    }

    public void PlayerName()
    {
        InputPlayerName = playerName.text;
        if (playerName.text.Length >= 2 && playerName.text.Length <= 10)
        {
            isPossiblePlayerName = true;
        }
        else
            isPossiblePlayerName= false;
    }
}
