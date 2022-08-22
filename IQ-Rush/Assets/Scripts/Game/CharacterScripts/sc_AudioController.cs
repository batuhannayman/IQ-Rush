using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_AudioController : MonoBehaviour
{
    [SerializeField] AudioClip win, lose, ding;
    [SerializeField] AudioSource audioSource;

    [SerializeField] public static sc_AudioController instance;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        instance = this;
    }

    public void PlayWin()
    {
        audioSource.PlayOneShot(win);
    }

    public void PlayLose()
    {
        audioSource.PlayOneShot(lose);
    }

    public void PlayDing()
    {
        audioSource.PlayOneShot(ding);
    }

    
}
