using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    private int Score;

    [SerializeField]
    private Text text;

    private void Start()
    {
        if(!PlayerPrefs.HasKey("Score_Save"))
        {
            Score = 0;
        }
        else
        {
            Score = PlayerPrefs.GetInt("Score_Save");
        }
        StartCoroutine(upgrade_score());
    }

    private void Update()
    {
        text.text = Score.ToString();
        PlayerPrefs.SetInt("Score_Save",Score);
    }

    IEnumerator upgrade_score()
    {
        while(true)
        {
            Score++;
            yield return new WaitForSeconds(1f);
        }
    }
}
