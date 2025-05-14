using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeSceneManager : MonoBehaviour
{
    public void IntoGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
