using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    public static bool isFirst = true;
    public ParticleSystem particle;
    public AudioMixerSnapshot audioNormal;
    public AudioMixerSnapshot audioPause;

    private void Start()
    {
        
        if (isFirst)
        {
            Time.timeScale = 0;
            audioPause.TransitionTo(0.5f);
            GetComponent<TextMeshProUGUI>().text = "BestScore: " + PlayerPrefs.GetInt("BestScore", 0);
        }
        
        else
        {
            audioNormal.TransitionTo(0.5f);
            Time.timeScale = 1;
            particle.gameObject.SetActive(true);
        }
        
    }
    public void ScaleTime()
    {
        audioNormal.TransitionTo(0.5f);
        particle.gameObject.SetActive(true);
        isFirst = false;
        Time.timeScale = 1;
    }
}
