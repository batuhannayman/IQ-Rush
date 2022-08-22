using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sc_LevelSelectManager : MonoBehaviour
{
    [SerializeField] int highest_Level;
    [SerializeField] Button btn2, btn3, btn4, btn5, btn6, btnBack;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("highest_Level"))
        {
            highest_Level = PlayerPrefs.GetInt("highest_Level");
            LevelView();
        }
    }

    void LevelView()
    {
        if (highest_Level > 1)
        {
            LevelUnlock(btn2);
        }

        if (highest_Level > 2)
        {
            LevelUnlock(btn3);
        }

        if (highest_Level > 3)
        {
            LevelUnlock(btn4);
        }

        if (highest_Level > 4)
        {
            LevelUnlock(btn5);
        }

        if (highest_Level > 5)
        {
            LevelUnlock(btn6);
        }
    }

    void LevelUnlock(Button btn)
    {
        btn.enabled = true;
        btn.image.color = new Color32(255, 255, 255, 255);
    }

    public void btn_1()
    {
        SceneManager.LoadScene(1);
    }

    public void btn_2()
    {
        SceneManager.LoadScene(2);
    }

    public void btn_3()
    {
        SceneManager.LoadScene(3);
    }

    public void btn_4()
    {
        SceneManager.LoadScene(4);
    }

    public void btn_5()
    {
        SceneManager.LoadScene(5);
    }

    public void btn_6()
    {
        SceneManager.LoadScene(6);
    }
}
