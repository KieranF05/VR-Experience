using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public List<int> correctSequence = new List<int> { 1, 2, 3 };

    private List<int> playerInput = new List<int>();

    public DrawerController drawer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            PressButton(1);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            PressButton(2);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            PressButton(3);
    }

    public void PressButton(int id)
    {
        Debug.Log("Received button: " + id);

        playerInput.Add(id);

        //  Prevent going over the sequence length
        if (playerInput.Count > correctSequence.Count)
        {
            Debug.Log("Too many inputs!");
            ResetPuzzle();
            return;
        }

        // Check progress
        for (int i = 0; i < playerInput.Count; i++)
        {
            if (playerInput[i] != correctSequence[i])
            {
                Debug.Log("Wrong!");
                ResetPuzzle();
                return;
            }
        }

        // Check if solved
        if (playerInput.Count == correctSequence.Count)
        {
            Debug.Log("Solved!");
            OnSolved();
        }
    }

    void OnSolved()
    {
        Debug.Log("Puzzle completed!");

        if (drawer != null)
        {
            drawer.OpenDrawer();
        }
    }

    void ResetPuzzle()
    {
        Debug.Log("Reset!");
        playerInput.Clear();
    }
}