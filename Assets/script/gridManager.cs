using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridManager : MonoBehaviour
{
	public bool testBool = false;
	public float timer = 0.1f;

	//private 
	private float _timer;
	private float multi = 1;

	void Start()
	{
		_timer = timer;
	}
	
	void Update()
	{
		_timer -= Time.deltaTime;
		if (_timer <= 0)
		{
			CheckSquare();
			_timer = timer / multi;
		}
	}

	void CheckSquare()
	{
		if(UIButton.start == false)
		{
			return;
		}
		else
		{
			for (int i = 0; i < GridGeneration.rows; i++)
			{
				for (int j = 0; j < GridGeneration.cols; j++)
				{
					if (GridGeneration.grid.isAlive(i, j))
					{
						if(!testBool)
						GridGeneration.grid.get(i, j).GetComponent<nodescript>().updateNeighbours(i, j);
						if(testBool)
						Debug.Log("["+i+","+j+"]");
					}
				}	
			}
			if (!testBool){
				for (int i = 0; i < GridGeneration.rows; i++)
				{
					for (int j = 0; j < GridGeneration.cols; j++)
					{
						GridGeneration.grid.get(i, j).GetComponent<nodescript>().update();
						
					}
				}
			}
		}
	}

	public void Reset()
	{
		for (int i = 0; i < GridGeneration.rows; i++)
		{
			for (int j = 0; j < GridGeneration.cols; j++)
			{
				GridGeneration.grid.get(i, j).GetComponent<nodescript>().NumberAllied = 0;
			}
		}
	}

	public void SetMuli(float i)
	{
		multi = i;
	}
}
