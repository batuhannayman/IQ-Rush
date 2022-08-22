using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc_Timer : MonoBehaviour
{
    [SerializeField] Image img_Timer;

    [SerializeField] Text timer;

    [SerializeField] float duration;

    [SerializeField] GameObject TimeIsUpPanel;

    float current_time;


    // Start is called before the first frame update
    void Start()
    {
        current_time = duration;
        timer.text = current_time.ToString();
        StartCoroutine(UpdateTime());
    }

    IEnumerator UpdateTime()
    {
        while (current_time >= 0)
        {
            img_Timer.fillAmount = Mathf.InverseLerp(0, duration, current_time);
            timer.text = current_time.ToString();

            if (current_time <= 0)
            {
                Time.timeScale = 0;
                sc_AudioController.instance.PlayLose();
                TimeIsUpPanel.SetActive(true);
            }
            
            yield return new WaitForSeconds(1f);
            current_time--;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
