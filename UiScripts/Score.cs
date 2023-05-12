using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    bool addS = false, addM;
    public GameVariables GV;
    public TMP_Text scoreText;
    public TMP_Text meterText;
    
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
    }
    private void Update()
    {
        //update score
        if (!addS)
        {
            StartCoroutine(AddScore());
        }
        scoreText.text = GV.score.ToString();
        //update meters
        if (!addM)
        {
            StartCoroutine(AddMeters());
        }

        meterText.text = GV.meters.ToString() + 'm';
    }
    IEnumerator AddScore()
    {
        addS = true;
        GV.score += 2;
        yield return new WaitForSeconds(1);
        addS = false;
    }
    IEnumerator AddMeters()
    {
        addM = true;
        GV.meters += 1;
        yield return new WaitForSeconds(1 / GV.gameSpeed);
        addM = false;
    }
}
