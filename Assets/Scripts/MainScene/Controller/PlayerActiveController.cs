using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerActiveController : MonoBehaviour
{
    public GameObject pangObject;
    public GameObject knightObject;
    private bool selectPang = SelectPlayerSystem.selectPang;
    private bool selectKnight = SelectPlayerSystem.selectKnight;

    private void Awake()
    {
        if (selectPang)
            pangObject.SetActive(selectPang);

        if (selectKnight)
            knightObject.SetActive(selectKnight);
    }
}
