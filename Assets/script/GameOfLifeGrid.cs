using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOfLifeGrid
{
	public static GameObject[,] gameObjects;

	Color aliveColor = new Color(1.0f, 1.0f, 1.0f, 0f);

	public GameOfLifeGrid(int rows, int cols)
	{
		gameObjects = new GameObject[rows, cols];
	}

	public void set(int i, int j, GameObject obj)
	{
		gameObjects[i, j] = obj;
	}

	public GameObject get(int i, int j)
	{
		return gameObjects[i, j];
	}

	public bool isAlive(int i, int j)
	{
		return GridGeneration.grid.get(i, j).GetComponent<SpriteRenderer>().color == aliveColor;
	}

	/*public GameObject[,] GetGrid()
	{
		return gameObjects;
	}*/
}
