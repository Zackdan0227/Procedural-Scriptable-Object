using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze1Coin : MonoBehaviour
{

    [HideInInspector]
    public bool isVisited = false;

    public GameObject coin;

    [HideInInspector]
    public float locX;
    [HideInInspector]
    public float locY;

	public void Init(float x, float y)
	{
        locX = x;
        locY = y;
    }
}
