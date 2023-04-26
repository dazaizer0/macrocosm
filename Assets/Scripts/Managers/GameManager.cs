using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public Slider TIME_SLIDER;
    public TextMeshProUGUI TIME_VALUE_TEXT;
    public TextMeshProUGUI G_TEXT;
    public TextMeshProUGUI F_TEXT;

    public float TIME_SCALE;

    void Start()
    {
        
        Time.timeScale = 0;
        TIME_SLIDER.value = 0f;
    }

    void Update()
    {
        
        Time.timeScale = TIME_SCALE;
        TIME_SCALE = TIME_SLIDER.value;
        TIME_VALUE_TEXT.text = TIME_SLIDER.value.ToString();
        G_TEXT.text = F.G.ToString();
        F_TEXT.text = F.F_.ToString();
    }

    public void retart()
    {

        SceneManager.LoadScene(0);
    }
}
