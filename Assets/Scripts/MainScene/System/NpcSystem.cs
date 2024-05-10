using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class NpcSystem : MonoBehaviour
{
    [SerializeField] private GameObject NpcUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NpcUI.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        NpcUI.gameObject.SetActive(false);
    }
}
