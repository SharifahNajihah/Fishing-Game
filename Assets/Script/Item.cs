using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item1", menuName = "AddItem/Item")]
public class Item : ScriptableObject
{
    public string fishName;
    public float fishPrice;
    public GameObject fishPrefab;
    public Sprite fishImage;
}
