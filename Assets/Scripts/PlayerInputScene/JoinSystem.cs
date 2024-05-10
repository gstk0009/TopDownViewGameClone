using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinSystem : MonoBehaviour
{

    public void Join()
    {
        bool isJoin = PlayerNameInputSystem.isPossiblePlayerName;

        if(isJoin)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("입력이 올바르지 않습니다.");
        }
    }
}
