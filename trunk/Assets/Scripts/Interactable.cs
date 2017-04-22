﻿using UnityEngine.EventSystems;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Interactable : MonoBehaviour
{
    protected virtual void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit) && hit.transform.gameObject == gameObject)
            {
                Interact();
            }
        }
    }

    protected virtual void Interact()
    {
    }
}
