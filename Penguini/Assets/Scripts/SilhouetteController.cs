using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class SilhouetteController : MonoBehaviour
{
    public int minAsk, maxAsk, item1Amount, item2Amount, item3Amount, item4Amount, decidedIndex;
    public TextMeshProUGUI orderedPumpkins, orderedApples, orderedFish, orderedCarrots;

    void Start()
    {
        GenerateOrder();
    }

    void Update()
    {
        return;
    }

    public void GenerateOrder()
    {
        item1Amount = UnityEngine.Random.Range(minAsk, maxAsk);
            orderedPumpkins.text = item1Amount.ToString();
        item2Amount = UnityEngine.Random.Range(minAsk, maxAsk);
            orderedApples.text = item2Amount.ToString();
        item3Amount = UnityEngine.Random.Range(minAsk, maxAsk);
            orderedFish.text = item3Amount.ToString();
        item4Amount = UnityEngine.Random.Range(minAsk, maxAsk);
            orderedCarrots.text = item4Amount.ToString();
    }
}
