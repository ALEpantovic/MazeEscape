using UnityEngine;

public class RotateAroundXAxis : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed, Space.Self);
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed, Space.Self);  // Rotate around X-axis
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.Self);     // Rotate around Y-axis
        transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed, Space.Self);
    }
}