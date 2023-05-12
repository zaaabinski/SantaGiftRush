using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Stamina : MonoBehaviour
{
    public Slider SD;
    bool sek = false;
    public int drain = 1;
    GameVariables GV;
    float velocity;
    float val;
    public void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();

    }
    private void FixedUpdate()
    {


        /*float ddd =  Mathf.SmoothDamp(SD.value, 0, ref velocity, 100 * GV.MaxStam * Time.deltaTime);
        SD.value = ddd*/;

        if (!sek)
        {
            StartCoroutine(ReduceStamina());
        }
        if (GV.ReindStam <= 0)
        {
            Time.timeScale = 0f;
            Debug.Log("End of fuel");
            GV.GameOver = true;

        }
    }

    IEnumerator ReduceStamina()
    {
        sek = true;
        GV.ReindStam -= drain;
        SD.value--;
        yield return new WaitForSeconds(1);
        sek = false;
    }

}
