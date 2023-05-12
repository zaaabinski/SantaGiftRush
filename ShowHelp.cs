using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHelp : MonoBehaviour
{
    public GameObject help;
    public GameObject other;
    public void Showing()
    {
        help.SetActive(true);
        other.SetActive(false);
    }
    public void CloseHe()
    {
        help.SetActive(false);
        other.SetActive(true);
    }
}
