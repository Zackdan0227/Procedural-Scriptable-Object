using UnityEngine;

[CreateAssetMenu(fileName = "ItemPrefabDatabase", menuName = "ScriptableObjects/ItemPrefabDatabase", order = 2)]
public class ItemPrefabDatabase : ScriptableObject
{
    public GameObject[] prefabList;
}