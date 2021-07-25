using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGeneration : MonoBehaviour
{
    public int _rows = 4;
    public int _cols = 4;
    public static int rows;
    public static int cols;
    public float tileSize = 1;
    public static GameOfLifeGrid grid; 
    public GameObject square;
    private int[] StartAliveX;
    private int[] StartAliveY;
    public bool IsHomeMade = false;
    public Camera cam;
    //private GameObject _lastGrid;
    //private lastGrid lastGrid;

    void Start()
    {
        //_lastGrid = GameObject.Find("lastGrid");
        //lastGrid = _lastGrid.GetComponent<lastGrid>();
        if (IsHomeMade)
        {
            rows = PlayerPrefs.GetInt("width", 50);
            cols = PlayerPrefs.GetInt("height", 50);
        }
		else
		{
            rows = _rows;
            cols = _cols;
        }
        grid = new GameOfLifeGrid(rows, cols);
        Generate();
        GenerateDead();
       
    }

    void Generate()
	{
        /*if(lastGrid.lastmove != null)
		{
            
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    
                    float posX = i * tileSize;
                    float posY = j * tileSize;
                    Vector3 pos = new Vector3(posX, posY, 0);
                    GameObject obj = Instantiate(lastGrid.lastmove[i,j], pos, transform.rotation);
                    obj.transform.SetParent(transform);
                    grid.set(i, j, obj);
                }
            }
            return;
		}*/
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < cols; j++)
			{
                float posX = i * tileSize;
                float posY = j * tileSize;
                Vector3 pos = new Vector3(posX, posY, 0);
                GameObject obj = Instantiate(square, pos, transform.rotation);
                obj.transform.SetParent(transform);
                grid.set(i, j, obj);
			}
		}
        float a = cols * tileSize;
        float b = rows * tileSize;
        transform.position = new Vector2(-a / 2, -b / 2);
		if (IsHomeMade)
		{
            cam.transform.position = new Vector3(0,0,-10);
		}
        
    }

    void GenerateDead()
	{
        if (StartAliveX != null)
		{
            for (int i = 0; i < StartAliveX.Length; i++)
			{
                grid.get(StartAliveX[i], StartAliveY[i]).GetComponent<nodescript>().StartAlive = true;

            }
		}
	}

    public void SetX(int[] x)
	{
        StartAliveX = x;
    }

    public void SetY(int[] y)
	{
        StartAliveY = y;
	}

    /*public GameObject[,] getGrid()
	{
        return grid.GetGrid();
    }*/
}
