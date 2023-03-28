using UnityEngine;
using System.Collections.Generic;

public class ChildObjectsManager : MonoBehaviour
{
    private List<GameObject> childObjects;

    void Update()
    {
        childObjects = new List<GameObject>();

        // Find all child GameObjects and add them to the list
        foreach (Transform child in transform)
        {
            if(!childObjects.Contains(child.gameObject))
            childObjects.Add(child.gameObject);
        }
    }

    // Public getter for the list of child GameObjects
    public List<GameObject> GetChildObjects()
    {
        return childObjects;
    }
}