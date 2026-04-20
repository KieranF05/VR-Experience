using UnityEngine;

public class MouseClickRaycast : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                VRButton button = hit.collider.GetComponent<VRButton>();
                if (button != null)
                {
                    button.SendMessage("Press");
                }
            }
        }
    }
}