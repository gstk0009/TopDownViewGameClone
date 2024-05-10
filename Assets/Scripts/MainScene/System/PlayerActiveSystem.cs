using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActiveSystem : MonoBehaviour
{
    public GameObject pangObject;
    public GameObject knightObject;
    public Text playerName;
    private bool selectPang = SelectPlayerSystem.selectPang;
    private bool selectKnight = SelectPlayerSystem.selectKnight;

    private void Awake()
    {
        playerName.text = PlayerNameInputSystem.InputPlayerName;

        if (selectPang)
            pangObject.SetActive(selectPang);

        if (selectKnight)
            knightObject.SetActive(selectKnight);
    }
}
