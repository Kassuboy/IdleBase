using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button mainMenu;



    void Start()
    {
        mainMenu.onClick.AddListener(LoadMainMenu);
    }

    void LoadMainMenu()
    {
        ScenesManager.Instance.LoadMainMenu();
    }

}
