using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class homeMadeLvl : MonoBehaviour
{
    public GameObject _Width;
    public GameObject _Height;
    public GameObject thiss;
    private int width;
    private int height;
    
    

    public void setSize()
	{
        width = int.Parse(_Width.GetComponent<Text>().text);
        height = int.Parse(_Height.GetComponent<Text>().text);
        if(width > 0 && height > 0)
		{
            desactivate();
            PlayerPrefs.SetInt("width", width);
            PlayerPrefs.SetInt("height", height);
            SceneManager.LoadScene(sceneName: "homeMade");
        }
    }

    public void activate()
	{
        thiss.SetActive(true);
	}

    public void desactivate()
	{
        thiss.SetActive(false);
    }

}
