using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SilhouetteController : MonoBehaviour
{

    public bool orderInProgress = false;
    public int minItems = 1;
    public int maxItems = 5;
    private int orderSize;
    private List<GameObject> orderContents = new List<GameObject>();

    //Orderable Items
    public GameObject item1, item2, item3, item4;

    void Awake()
    {
        GenerateOrder();
    }

    public void Update()
    {

    }

    public void GenerateOrder()
    {
        if (orderInProgress == false)
        {
            orderSize = UnityEngine.Random.Range(minItems, maxItems);
            for (int i = 0; i < orderSize; i++)
            {
                orderContents.Add(RandomizeItem());
            }
            Debug.Log(orderSize);
            Debug.Log(orderContents);

        }
    }

    public GameObject RandomizeItem()
    {
        int randItem = UnityEngine.Random.Range(1, 4);
        switch (randItem)
        {
            case 1:
                if (randItem == 1)
                {
                    return item1;
                }
                break;

            case 2:
                if (randItem == 2)
                {
                    return item2;
                }
                break;

            case 3:
                if (randItem == 3)
                {
                    return item3;
                }
                break;

            case 4:
                if (randItem == 4)
                {
                    return item4;
                }
                break;

            default:
                break;
        }
        return null;
    }
}
