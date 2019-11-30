using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageSelection : MonoBehaviour
{
    [SerializeField] private string selectableTag = "PickMe";
    [SerializeField] private Material flashlightMaterial;
    [SerializeField] private Material normalMaterial;

    private Transform Aselection;
    
    private void Update()
    {
        if (Aselection != null)
        {
            var selectionRenderer = Aselection.GetComponent<Renderer>();
            selectionRenderer.material = normalMaterial;
            Aselection = null;
        }
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = flashlightMaterial;
                }

                Aselection = selection;
            }
            
        }
    }
}
