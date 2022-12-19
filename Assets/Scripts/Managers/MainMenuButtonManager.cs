using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtonManager : MonoBehaviour
{
    [SerializeField] Button gameScene;



    void Start()
    {
        gameScene.onClick.AddListener(LoadGameScene);
    }

    void LoadGameScene()
    {
        ScenesManager.Instance.LoadNewGame();
    }
}
