using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text ui;
    public void Increment()
    {
        GameManager.masks += GameManager.multiplier;
        PlayerPrefs.SetInt("masks", GameManager.masks);
    }

    public void Buy(int num)
    {
        if(num == 1 && GameManager.masks >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.masks -= 25;
            PlayerPrefs.SetInt("masks", GameManager.masks);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 2 && GameManager.masks >= 125)
        {
            GameManager.multiplier += 10;
            GameManager.masks -= 125;
            PlayerPrefs.SetInt("masks", GameManager.masks);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 3 && GameManager.masks >= 1500)
        {
            GameManager.multiplier += 100;
            GameManager.masks -= 1500;
            PlayerPrefs.SetInt("masks", GameManager.masks);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);

        }
    }


    void Update()
    {
        ui.text = "Masks: " + GameManager.masks;
    }
}
