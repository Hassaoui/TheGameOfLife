using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsscript : MonoBehaviour
{
    bool IsActive = false;
    public GameObject obj;
    void Start()
    {
        IsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (IsActive)
		{
            obj.SetActive(true);
		}
		else
		{
            obj.SetActive(false);
		}
    }

    public void Activate()
	{
        IsActive = !IsActive;
	}
}
