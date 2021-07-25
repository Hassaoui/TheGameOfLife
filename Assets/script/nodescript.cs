using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class nodescript : MonoBehaviour
{
	Color dead = new Color(1.0f, 1.0f, 1.0f, 1f);
	Color alive = new Color(1.0f, 1.0f, 1.0f, 0f);

	public int NumberAllied = 0;

	public bool StartAlive = false;

	//public bool _alive = false;

	private int[] neighboursX = {-1, -1, -1, 0, 0, 1, 1, 1};

	private int[] neighboursY = {-1, 0, 1, -1, 1, -1, 0, 1};

	/*private int[8] neighbours = {{-1,-1}, {-1, 0} ,{-1, 1},
								  { 0,-1},          { 0, 1},
								  { 1,-1}, {+1, 0}, {+1,+1}};*/
	private SpriteRenderer ren;

	void Start()
	{
		
		ren = this.GetComponent<SpriteRenderer>();
		if (StartAlive)
		{
			ren.color = alive;
		}
	}

	void OnMouseDown()
	{
		if(!UIButton.start && UIButton.clicky)
		{
			if (EventSystem.current.IsPointerOverGameObject())
				return;
			if (ren.color == dead)
			{
				ren.color = new Color(1.0f, 1.0f, 1.0f, 0f);
			}
			else
			{
				ren.color = dead;
			}
		}
	}

	public void updateNeighbours(int i, int j)
	{
		for (int s = 0; s < neighboursX.Length; s++)
		{
			if (i + neighboursX[s] < 0 || j + neighboursY[s] < 0 || i + neighboursX[s] >= GridGeneration.rows || j + neighboursY[s] >= GridGeneration.cols)
			{
				
			}
			else
			{
				GridGeneration.grid.get(i + neighboursX[s], j + neighboursY[s]).GetComponent<nodescript>().NumberAllied++;
			}
		}
	}

	public void update()
	{
		/*if(ren.color == alive)
		{
			_alive = true;
		}
		else
		{
			_alive = false;
		}*/
		if(NumberAllied < 2 && ren.color == alive)
		{
			ren.color = dead;
			NumberAllied = 0;
			return;
		}
		else if(ren.color == alive && (NumberAllied == 2 || NumberAllied == 3))
		{
			NumberAllied = 0;
			return;
		}
		else if(NumberAllied > 3 && ren.color == alive)
		{
			ren.color = dead;
			NumberAllied = 0;
			return;
		}
		else if(NumberAllied == 3 && ren.color == dead)
		{
			ren.color = alive;
			NumberAllied = 0;
			return;
		}
		else
		{
			NumberAllied = 0;
			return;
		}

	}
}
