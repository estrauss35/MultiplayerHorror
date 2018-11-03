using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public List<InventoryItem> items;

    public void Start()
    {
        items = new List<InventoryItem>();
    }

	public void AddItem(InventoryItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(InventoryItem item)
    {
        items.Remove(item);
    }
}
