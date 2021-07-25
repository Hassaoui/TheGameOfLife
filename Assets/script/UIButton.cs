using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButton : MonoBehaviour
{
    public static bool start = false;
	public static bool clicky = true;
	public bool canClick = false;
	private bool Activation = false;
	public GameObject Pause;
	public GameObject continu;
	public GameObject[] displayMulti;
	public bool canSaveLast = false;

	//private
	private GameObject obj;
	private gridManager GM;
	private GameObject temp;
	private GridGeneration GG;
	private float[] multiSpeed = { 1, 2, 4, 0.25f, 0.17f };
	private float multi;
	private int i = 1;
	//private bool firstSpace = true;
	private GameObject[,] LM;
	private GameObject _lastGrid;
	private lastGrid lastGrid;
	private int[,] _LM;

	void Start()
	{
		multi = multiSpeed[0];
		obj = GameObject.Find("GridManager");
		GM = obj.GetComponent<gridManager>();
		temp = GameObject.Find("GridGenerator");
		GG = temp.GetComponent<GridGeneration>();
		//_lastGrid = GameObject.Find("lastGrid");
		//lastGrid = _lastGrid.GetComponent<lastGrid>();
		clicky = canClick;
	}

    void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			/*if (canSaveLast && firstSpace)
			{
				LM = GameOfLifeGrid.gameObjects;
				for (int i = 0; i < GridGeneration.rows; i++)
				{
					for (int j = 0; j < GridGeneration.cols; j++)
					{
						if(LM[i,j].gameObject.GetComponent<nodescript>()._alive == true)
						{
							Debug.Log("hey");
						}
					}
				}
				lastGrid.SetLastMove(LM);
				firstSpace = false;
			}*/
			Activation = !Activation;
		}
			gameStart();
	}

    public void gameStart()
	{
		if (Activation && !start)
		{
			continu.SetActive(true);
			Pause.SetActive(false);
			start = true;
		}
		if(!Activation && start)
		{
			continu.SetActive(false);
			Pause.SetActive(true);
			start = false;
		}
	}

	public void RestartLevel()
	{
		GM.Reset();
		Activation = false;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void buttonStop()
	{
		Activation = !Activation;
	}

	public void multiVitesse()
	{
		multi = multiSpeed[i];
		clear();
		displayMulti[i].SetActive(true);
		if(i == multiSpeed.Length - 1)
		{
			i = 0;
		}
		else
		{
			i++;
		}
		GM.SetMuli(multi);
	}

	private void clear() {
		for (int j = 0; j < displayMulti.Length; j++)
		{
			displayMulti[j].SetActive(false);
		}
	}

}
