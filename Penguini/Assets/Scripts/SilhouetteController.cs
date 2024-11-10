using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Order
{
    public List<GameObject> ingredients = new();
}
public class SilhouetteController : MonoBehaviour
{
    public List<Order> listOrders = new();

    private GameManager gameManager;
    //private UIManager uiManager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    void Start()
    {
        GenerateRecipe(3);
        Debug.Log(listOrders);
        //uiManager.UpdateRecipieListUI();
    }

    public void GenerateRecipe(int nbReceipes)
    {
        for (int i = 0; i < nbReceipes; i++)
        {
            Order NewReceipie = new();
            int nbIngredientsInDish = UnityEngine.Random.Range(1, 4);
            for (int j = 0; j < nbIngredientsInDish; j++)
            {
                GameObject NewIngredient = TakeRandomIngredient();
                NewReceipie.ingredients.Add(NewIngredient);
            }
            listOrders.Add(NewReceipie);
        }
    }

    public void GenerateNewRecipe(int nbRecipies)
    {
        listOrders.RemoveAt(0);
        GenerateRecipe(nbRecipies);
        //uiManager.UpdateRecipieListUI();
    }

    GameObject TakeRandomIngredient()
    {
        GameObject Ingredient = gameManager.uncutItems[UnityEngine.Random.Range(0, gameManager.uncutItems.Length)];
        return Ingredient;
    }

    public Order GetNextDishToDeliver()
    {
        Order Receipie = listOrders.First();
        return Receipie;
    }

    public List<GameObject> GetAllIngredients(Order dishToPrepare)
    {
        return dishToPrepare.ingredients;
    }


    /*public bool orderInProgress = false;
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
    }*/
}
