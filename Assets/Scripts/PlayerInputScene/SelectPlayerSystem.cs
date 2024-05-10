using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPlayerSystem : MonoBehaviour
{
    public static bool selectPang = true;
    public static bool selectKnight = false;

    [SerializeField] private Image PlayerImage;
    [SerializeField] private Sprite PangSprite;
    [SerializeField] private Sprite KnightSprite;

    public void SelectPang()
    {
        selectPang = true;
        PlayerImage.sprite = PangSprite;
    }

    public void SelectKnight()
    {
        selectPang = false;
        selectKnight = true;
        PlayerImage.sprite = KnightSprite;
    }
}
