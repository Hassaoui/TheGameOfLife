using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastGrid : MonoBehaviour
{
    public static GameObject[,] lastmove;
    public bool change = false;

	void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
	}

    public void SetLastMove(GameObject[,] LM)
	{
        lastmove = LM;
	}

   void Update()
	{
        //show();
        if (Input.GetKeyDown(KeyCode.Z))
		{
            show();
		}

    }

    private void show()
	{
		for (int i = 0; i < 15; i++)
		{
			for (int j = 0; j < 15; j++)
			{
				if (lastmove[i, j] == null)
				{
					Debug.Log("dfvbn");
				}
			}
		}
	}
    
}
