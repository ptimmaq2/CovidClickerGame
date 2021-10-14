using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static int masks;
    public static int multiplier;

    void Start()
    {
        masks = 0;
        multiplier = PlayerPrefs.GetInt("multiplier", 1);
        masks = PlayerPrefs.GetInt("masks", 0);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
