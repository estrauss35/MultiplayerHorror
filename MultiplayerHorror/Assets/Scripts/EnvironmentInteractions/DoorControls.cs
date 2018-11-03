using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityEngine;

public class DoorControls : MonoBehaviour
{

    public GameObject requiredKey;
    public bool unlocked;

    public void unlockDoor(GameObject interactingPlayer)
    {
        var playerInventory = interactingPlayer.GetComponent<InventorySystem>().items;

        foreach(InventoryItem item in playerInventory)
        {
            if(item.gameObject == requiredKey)
            {
                unlocked = true;
            }
        }
    }

    public void openDoor()
    {
        gameObject.SetActive(false);
    }
}
