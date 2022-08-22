using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sc_MainMenuButtons : MonoBehaviour
{

    [SerializeField] GameObject TutorialPanel, MainMenuPanel, LevelsPanel;
    [SerializeField] int highest_Level;

    void Start()
    {
        if (PlayerPrefs.HasKey("highest_Level"))
        {
            highest_Level = PlayerPrefs.GetInt("highest_Level");
        }
        else
        {
            highest_Level = 1;
            PlayerPrefs.SetInt("highest_Level", 1);
        }
    }

    public void PlayClicked()
    {
        SceneManager.LoadScene(highest_Level);
    }

    public void ExitClicked()
    {
        Application.Quit();
    }

    public void BackClicked()
    {
        MainMenuPanel.SetActive(true);
        LevelsPanel.SetActive(false);
        TutorialPanel.SetActive(false);
    }

    public void TutorialClicked()
    {
        MainMenuPanel.SetActive(false);
        LevelsPanel.SetActive(false);
        TutorialPanel.SetActive(true);
    }

    public void LevelsClicked()
    {
        MainMenuPanel.SetActive(false);
        LevelsPanel.SetActive(true);
        TutorialPanel.SetActive(false);
    }

    


}
