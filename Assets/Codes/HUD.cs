using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Inventory Inventory;

    // Start is called before the first frame update
    void Start()
    { 
        Inventory.ItemAdded += InventoryScript_ItemAdded;
    }



    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventory = transform.Find("Inventory");
        foreach (Transform slot in inventory)
        {
            Image image = slot.GetChild(0).GetChild(0).GetComponent<Image>();

            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                break;
            }

        }


    }

}
