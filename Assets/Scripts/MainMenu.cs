using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject levelSelection;
    [SerializeField]
    private GameObject settings;

    public void PlayGame()
    {
        levelSelection.SetActive(true);
    }

    public void Back()
    {
        EventSystem.current.currentSelectedGameObject.transform.parent.gameObject.SetActive(false);
    }

    public void LoadLevel()
    {
        int index = int.Parse(EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TextMeshProUGUI>().text);
        SceneManager.LoadScene(index);
    }

    public void Settings()
    {
        settings.SetActive(true);
    }
}
