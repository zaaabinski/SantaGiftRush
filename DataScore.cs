using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization;
using System;

public class DataScore : MonoBehaviour
{
     public GameVariables GV;
     private void Awake()
     {
         GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
        StartCoroutine(UpdText());
     }
    [SerializeField] private LocalizedString localStringScore;
    [SerializeField] private TextMeshProUGUI textComp;

    private void OnEnable()
    {
        localStringScore.Arguments = new object[] { GV.score,GV.GiftsIn,GV.meters,GV.HS };
        localStringScore.StringChanged += UpdateText;

    }
    private void OnDisable()
    {
        localStringScore.StringChanged -= UpdateText;
    }
    private void UpdateText(string value)
    {
        textComp.text = value;
    }
    IEnumerator UpdText()
    {
        yield return new WaitForSeconds(0.05f);
        localStringScore.Arguments[0] = GV.score.ToString();
        localStringScore.Arguments[1] = GV.GiftsIn.ToString();
        localStringScore.Arguments[2] = GV.meters.ToString();
        localStringScore.Arguments[3] = GV.Highscore.ToString();
        localStringScore.RefreshString();
    }
}
