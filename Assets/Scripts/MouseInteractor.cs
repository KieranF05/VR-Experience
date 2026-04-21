using UnityEngine;
using UnityEngine.InputSystem;

public class MouseInteractor : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        if (Mouse.current == null) return;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {

            Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                VRButton button = hit.collider.GetComponent<VRButton>();

                if (button != null)
                {

                    button.Press();
                }

            }
        }
    }
}
