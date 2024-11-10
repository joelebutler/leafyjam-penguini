using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;


public class SilhouetteController : MonoBehaviour
{
    public int minAsk, maxAsk, randAsk, item1Amount, item2Amount, item3Amount, item4Amount, decidedIndex;

    void Awake()
    {
        GenerateOrder();
        Debug.Log(item1Amount + " " + item2Amount + " " + item3Amount + " " + item4Amount);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GenerateOrder();
        }
    }

    public void GenerateOrder()
    {
        for (int i = decidedIndex; i < 3; i++)
        {
            randAsk = UnityEngine.Random.Range(minAsk, maxAsk);
            switch (decidedIndex)
            {
                case 0:
                    item1Amount = randAsk;
                    break;
                case 1:
                    item2Amount = randAsk;
                    break;
                case 2:
                    item3Amount = randAsk;
                    break;
                case 3:
                    item4Amount = randAsk;
                    break;
                default:
                    break;
            }
        }
    }
}
