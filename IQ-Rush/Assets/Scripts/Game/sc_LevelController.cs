using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sc_LevelController : MonoBehaviour
{
    public void MainMenuClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void TryAgainClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void LevelChange(int i)
    {
        if (PlayerPrefs.GetInt("highest_Level") < i)
        {
            PlayerPrefs.SetInt("highest_Level", i);
        }
        SceneManager.LoadScene(i);
    }

    public void level1GoNextClicked()
    {
        LevelChange(2);
    }

    public void level2GoNextClicked()
    {
        LevelChange(3);
    }

    public void level3GoNextClicked()
    {
        LevelChange(4);
    }

    public void level4GoNextClicked()
    {
        LevelChange(5);
    }

    public void level5GoNextClicked()
    {
        LevelChange(6);
    }

    public void level6GoNextClicked()
    {
        LevelChange(7);
    }

    
}
