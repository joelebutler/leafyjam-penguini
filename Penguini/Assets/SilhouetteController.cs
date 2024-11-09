using UnityEngine;

public class SilhouetteController : MonoBehaviour
{
    public float difficulty = 3f;
    public int highRND = 1000;
    private int IDCount = 0;
    private Dictionary<int, Dictionary<string, float>> ActiveOrders = new Dictionary<int, Dictionary<string, float>>();

    void makeOrder()
    {
        // Set a random amount of each within the range of the curent difficulty, increase the difficulty, add order to order list.
        Random rnd = new Random();
        private Dictionary<string, float> order = new Dictionary<string, float>();
        difficultyInc = difficultyInc + 0.25f;
        order.Add("fish", rnd.Next(0, difficulty));
        order.Add("carrot", rnd.Next(0, difficulty));
        order.Add("apple", rnd.Next(0, difficulty));
        order.Add("pumpkin", rnd.Next(0, difficulty));
        order.Add("timer", 60f);
        ActiveOrders.add(IDCount, order);
        Debug.Log("Added order: " + IDCount);
        IDCount += 1;
    }

    void removeOrder(int ID)
    {
        // remove the specific order at current ID
        ActiveOrders.remove(ID);
        Debug.Log("Removed order: " + ID);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // random chance of new guy showing up if there isn't 3 already
        Random rnd = new Random();
        if (rnd.Next(0, highRND) == highRND - 1 && ActiveOrders.Count <= 3) {
            makeOrder()
        }
        // decrement the timer on each order if it still has time, otherwise quit program
        foreach(KeyValuePair<int, Dictionary> order in ActiveOrders) {
            if (order.Key == "timer" && order.Value <= 0) {
                Application.Quit();
            } 
            if (order.Key == "timer") {
                order.Value = order.Value - 1f;
            }
        }
    }
}
