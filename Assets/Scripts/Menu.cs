using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public static bool isFirst = true;
    public ParticleSystem particle;
    private void Awake()
    {
        if (isFirst)
        {
            Time.timeScale = 0;
            GetComponent<TextMeshProUGUI>().text = "BestScore: " + PlayerPrefs.GetInt("BestScore", 0);
        }
        
        else
        {
            Time.timeScale = 1;
        }
    }
    public void ScaleTime()
    {
        particle.gameObject.SetActive(true);
        isFirst = false;
        Time.timeScale = 1;
    }
}
