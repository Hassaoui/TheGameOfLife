﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public string nameNextScene;
    public void changeDcene()
	{
        SceneManager.LoadScene(sceneName: nameNextScene);
    }
}
