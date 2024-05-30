using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    // Reference to the LineRenderer component
    private LineRenderer lineRenderer;

    void Start()
    {
        // Create a new GameObject with a LineRenderer component
        GameObject lineObject = new GameObject("Line");
        lineRenderer = lineObject.AddComponent<LineRenderer>();

        // Set LineRenderer properties
        lineRenderer.positionCount = 2; // Two points to create a line
        lineRenderer.startWidth = 0.1f; // Line width at the start
        lineRenderer.endWidth = 0.1f; // Line width at the end
        lineRenderer.material = new Material(Shader.Find("Standard")); // You can use a different material if needed

        // Set the positions of the two points to create a line
        Vector3 startPoint = new Vector3(0f, 0f, 0f);
        Vector3 endPoint = new Vector3(2f, 0f, 0f);
        lineRenderer.SetPosition(0, startPoint);
        lineRenderer.SetPosition(1, endPoint);
    }
}
