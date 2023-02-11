using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IInventoryItem
{
    public string Name
    {
        get
        {
            return name;
        }
    }
    public Sprite _image = null;
    public Sprite Image
    {
        get
        {
            return _image;
        }
    }

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

}
