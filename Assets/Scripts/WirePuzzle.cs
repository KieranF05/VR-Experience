using UnityEngine;

public class WirePuzzle : MonoBehaviour
{
    public Wire[] wires;
    public Drawer drawer;

    void Update()
    {
        foreach (Wire w in wires)
        {
            if (!w.IsCorrect())
                return;
        }

        OpenDrawer();
    }

    void OpenDrawer()
    {
        Debug.Log("Solved!");
        drawer.Open();
    }
}