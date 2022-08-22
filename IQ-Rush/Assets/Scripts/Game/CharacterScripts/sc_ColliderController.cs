using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sc_ColliderController : MonoBehaviour
{
    [SerializeField] GameObject stack1, stack2, stack3, stack4, stack5;
    [SerializeField] GameObject rubic_OnHand;
    [SerializeField] GameObject LevelDonePanel, gameOverPanel, gameFinishPanel;
    [SerializeField] Text txt_RubicCount;
    [SerializeField] int rubic_Count = 5;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "RubicCube" && sc_AnimationController.instance.isCarrying == false)
        {
            TakedRubic(collider);
        }
        
        if (collider.gameObject.tag == "Box" && sc_AnimationController.instance.isCarrying == true)
        {
            DroppedRubic();
        }

        if (collider.gameObject.tag == "Obstacle")
        {
            ObstacleCrash();
        }

    }

    void ObstacleCrash()
    {
        sc_AudioController.instance.PlayLose();
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    void TakedRubic(Collider t_collider)
    {
        Destroy(t_collider.gameObject);
        sc_AnimationController.instance.Carrying();
        rubic_OnHand.SetActive(true);
    }

    void DroppedRubic()
    {
        sc_AnimationController.instance.Running();
        rubic_OnHand.SetActive(false);
        rubic_Count--;
        CubeCarried();
        switch(rubic_Count)
        {
            case 4:
                stack2.SetActive(true);
                break;
            case 3:
                stack3.SetActive(true);
                break;
            case 2:
                stack4.SetActive(true);
                break;
            case 1:
                stack5.SetActive(true);
                break;
            case 0:
                stack5.SetActive(true);
                CubeCarried();
                sc_AudioController.instance.PlayWin();
                Time.timeScale = 0;

                if (SceneManager.GetActiveScene().name != "Level_6")
                {
                    LevelDonePanel.SetActive(true);
                    PlayerPrefs.SetInt("highest_Level", PlayerPrefs.GetInt("highest_Level") + 1);
                }
                else
                {
                    gameFinishPanel.SetActive(true);
                }
                
                break;
        }
    }

    void CubeCarried()
    {
        txt_RubicCount.text = rubic_Count.ToString();
        sc_AudioController.instance.PlayDing();
    }

}
