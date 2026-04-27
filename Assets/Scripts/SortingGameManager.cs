using UnityEngine;

public class SortingGameManager : MonoBehaviour
{
    public BasketZone coalBasket;
    public BasketZone energyBasket;
    public GameObject door;

    private bool opened = false;

    void Update()
    {
        if (opened) return;

        if (coalBasket.IsComplete() && energyBasket.IsComplete())
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        opened = true;

        Debug.Log("Puzzle Complete!");

        if (door != null)
        {
            door.transform.position += new Vector3(0, 2f, 0);
        }
    }
}
