using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialSwaper : MonoBehaviour
{

    public Material Material1;
    public Material Material2;
    public GameObject Object;

    // Use a boolean to track the current material state
    private bool usingMaterial1 = true;

    IEnumerator Start()
    {
        // Wait 30 seconds before setting the initial material
        yield return new WaitForSeconds(30);

        // Set the initial material
        Object.GetComponent<MeshRenderer>().material = Material1;

        StartCoroutine(SwapMaterials());
    }

    IEnumerator SwapMaterials()
    {
        while (true)
        {
            // Swap materials based on the current state
            Object.GetComponent<MeshRenderer>().material = usingMaterial1 ? Material2 : Material1;
            usingMaterial1 = !usingMaterial1; // Toggle the state for the next swap

            // Wait for 30 seconds before the next swap
            yield return new WaitForSeconds(30);
        }
    }
}