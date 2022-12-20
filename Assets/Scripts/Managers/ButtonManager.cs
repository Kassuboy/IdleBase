using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button mainMenu;



    void Start()
    {
        mainMenu.onClick.AddListener(LoadMainMenu);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
        //ScenesManager.Instance.LoadMainMenu();
    }

}
