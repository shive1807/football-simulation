using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class OutlineRenderer : MonoBehaviour
{
    private readonly float GROUND_SIZE = 5.0f;
    private LineRenderer lineRenderer;
    private MeshFilter meshFilter;

    void Start()
    {
        // Create LineRenderer component
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = 5; // Number of points to create a closed loop around the plane
        lineRenderer.loop = true;

        // Get the MeshFilter component
        meshFilter = GetComponent<MeshFilter>();

        // Set LineRenderer properties
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.material = new Material(Shader.Find("Standard"));

        // Draw the outline around the plane
        // DrawOutline();
        CreateRoad();
        CreateRoad2();
    }

    void DrawOutline()
    {
        // Get the vertices of the plane
        Vector3[] vertices = {
            new (+GROUND_SIZE, 0, +GROUND_SIZE),
            new (+GROUND_SIZE, 0, -GROUND_SIZE),
            new (-GROUND_SIZE, 0, -GROUND_SIZE),
            new (-GROUND_SIZE, 0, +GROUND_SIZE) };
        // int point = vertices.Length / 4;

        Debug.Log(vertices.Length);
        // Set the position of the LineRenderer to create a closed loop around the plane
        for (int i = 0; i < vertices.Length; i++)
        {
            lineRenderer.SetPosition(i, transform.TransformPoint(vertices[i]));
            Debug.Log(vertices[i]);
        }

        // Set the fifth point to close the loop
        lineRenderer.SetPosition(4, transform.TransformPoint(vertices[0]));
    }

    private void CreateRoad(){
        // Get the vertices of the plane
        Vector3[] vertices = {
            new (+0, 0, +GROUND_SIZE),
            // new (+GROUND_SIZE, 0, -GROUND_SIZE),
            new (-0, 0, -GROUND_SIZE) };
            // new (-GROUND_SIZE, 0, +GROUND_SIZE) };
        // int point = vertices.Length / 4;

        Debug.Log(vertices.Length);
        // Set the position of the LineRenderer to create a closed loop around the plane
        for (int i = 0; i < vertices.Length; i++)
        {
            lineRenderer.SetPosition(i, transform.TransformPoint(vertices[i]));
            Debug.Log(vertices[i]);
        }

        // Set the fifth point to close the loop
        // lineRenderer.SetPosition(4, transform.TransformPoint(vertices[0]));
    }

    private void CreateRoad2()
    {
        // Get the vertices of the plane
        Vector3[] vertices = {
            new (+GROUND_SIZE, 0, 0),
            // new (+GROUND_SIZE, 0, -GROUND_SIZE),
            new (-GROUND_SIZE, 0, 0) };
        // new (-GROUND_SIZE, 0, +GROUND_SIZE) };
        // int point = vertices.Length / 4;

        Debug.Log(vertices.Length);
        // Set the position of the LineRenderer to create a closed loop around the plane
        for (int i = 0; i < vertices.Length; i++)
        {
            lineRenderer.SetPosition(i, transform.TransformPoint(vertices[i]));
            Debug.Log(vertices[i]);
        }

        // Set the fifth point to close the loop
        // lineRenderer.SetPosition(4, transform.TransformPoint(vertices[0]));
    }
}
