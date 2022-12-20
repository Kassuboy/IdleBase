using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtonManager : MonoBehaviour
{
    [SerializeField] Button gameScene;



    void Start()
    {
        gameScene.onClick.AddListener(LoadGameScene);
    }

    void LoadGameScene()
    {
        SceneManager.LoadSceneAsync("GameScene");
        //ScenesManager.Instance.LoadNewGame();
    }
}
