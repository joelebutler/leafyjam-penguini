using System;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Interactable : MonoBehaviour
{
    //Enum to select interactable type
    enum typeList
    {
        AppleTree,
        FishingRod,
        FarmStand
    };

    // Creates drop down list of enums in inspector, allows quick type selection (probably redundant but i dont care mwahhahahahah)
    [SerializeField]
    typeList type = new typeList();

    // Reference to the apple prefab for spawning purposes
    public GameObject apple;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (type == typeList.AppleTree)
            {
                Instantiate(apple, transform.position, Quaternion.identity);
            } else 
            {
                return;
            }
        }
    }
}
