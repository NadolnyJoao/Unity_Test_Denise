using UnityEngine;
using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;

using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;




public class GD_PlayerInteract : MonoBehaviour
{
    public Camera PlayerCamera;
    public float InteractionDistance = 3f;
    public GameObject interactionText;
    private GD_InteractObject currentInteractable;

    void Update()
    {
        Ray ray = PlayerCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, InteractionDistance))
        {
            GD_InteractObject interactableObject = hit.collider.GetComponent<GD_InteractObject>();
            if (interactableObject != null && interactableObject != currentInteractable)
            {
                currentInteractable = interactableObject;
                interactionText.SetActive(true);
                TextMeshProUGUI textComponent = interactionText.GetComponent<TextMeshProUGUI>();

                if (textComponent != null)
                {
                    textComponent.text = currentInteractable.GetInteractionText();
                }
            }
        }
        else
        {
            currentInteractable = null;
            interactionText.SetActive(false);
        }

    }
    public void OnInteract()
    {
        
        currentInteractable?.Interact();
    }


}