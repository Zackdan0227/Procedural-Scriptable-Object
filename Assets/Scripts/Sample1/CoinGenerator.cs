using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinGenerator : MonoBehaviour
{
    [SerializeField]
    ItemPrefabDatabase ItemPrefab;
    public GameObject MazeGenerator;
    [SerializeField]
    Transform itemGroup;

    [SerializeField]
    public int numItem = 10;

    public GameObject childObjectsManagerObject;
    private ChildObjectsManager childObjectsManager;
    private List<GameObject> childObjects;
    private Maze1Generator maze1Generator;
    int mazeX;
    int mazeY;
    int maxChildren = 0;
    bool once = true;

    // Start is called before the first frame update
    void Start()
    {
        maze1Generator = MazeGenerator.GetComponent<Maze1Generator>();
        mazeX = maze1Generator.mazeX;
        mazeY = maze1Generator.mazeY;

    }
    void Update()
    {
        if (once)
        {
            childObjectsManager = childObjectsManagerObject.GetComponent<ChildObjectsManager>();
            childObjects = childObjectsManager.GetChildObjects();


            if (childObjects != null)
            {
                Debug.Log(childObjects.Count);
                once = false;
                GenerateCoin();
            }

        }
    }

    void GenerateCoin()
    {




        for (int x = 0; x < numItem; x++)
        {
            int randomIndex = Random.Range(0, numItem);
            Maze1Coin eatable = Instantiate(ItemPrefab.prefabList[0], itemGroup).GetComponent<Maze1Coin>();

            int randomInd = Random.Range(0, childObjects.Count);

            float xPos = childObjects[randomInd].transform.position.x;
            Debug.Log(xPos);
            float zPos = childObjects[randomInd].transform.position.z;
            Debug.Log(zPos);
            Vector3 newPos = new Vector3(xPos,1,zPos);
            eatable.transform.position = newPos;
        }

    }

}
