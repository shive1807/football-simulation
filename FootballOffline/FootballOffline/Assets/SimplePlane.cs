using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SimplePlane : MonoBehaviour
{
    void Start()
    {
        // Create a new mesh
        Mesh mesh = new Mesh();

        // Define vertices for a simple plane
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(-1f, 0f, -1f),
            new Vector3(1f, 0f, -1f),
            new Vector3(1f, 0f, 1f),
            new Vector3(-1f, 0f, 1f),
        };

        // Define triangles (two triangles to form a quad)
        int[] triangles = new int[]
        {
            0, 1, 2,
            0, 2, 3,
        };

        // Set mesh properties
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // Recalculate normals and bounds
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        // Get or add MeshFilter component
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null)
            meshFilter = gameObject.AddComponent<MeshFilter>();

        // Get or add MeshRenderer component
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer == null)
            meshRenderer = gameObject.AddComponent<MeshRenderer>();

        // Assign the created mesh to the MeshFilter
        meshFilter.mesh = mesh;
    }
}
