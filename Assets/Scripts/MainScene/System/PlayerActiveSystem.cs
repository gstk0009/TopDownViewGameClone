using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActiveSystem : MonoBehaviour
{
    public GameObject pangObject;
    public GameObject knightObject;
    public Text InGamePlayerName;
    public Text AttendPlayerNmae;
    private bool selectPang = SelectPlayerSystem.selectPang;
    private bool selectKnight = SelectPlayerSystem.selectKnight;

    private void Awake()
    {
        InGamePlayerName.text = PlayerNameInputSystem.InputPlayerName;
        AttendPlayerNmae.text = PlayerNameInputSystem.InputPlayerName;

        if (selectPang && !selectKnight)
            pangObject.SetActive(selectPang);

        if (selectKnight && !selectPang)
            knightObject.SetActive(selectKnight);
    }
}
