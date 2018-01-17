using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleScript : MonoBehaviour {

    Mesh mesh;
    MeshRenderer meshRenderer;
    Vector3[] vertices;
    int[] triangles;
    public Material material;

	// Use this for initialization
	void Start () {
        gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        vertices = new[] {
            new Vector3(0,0,0),
            new Vector3(0,5,0),
            new Vector3(5,0,0),
        };

        mesh.vertices = vertices;

        triangles = new[] { 0, 1, 2 };

        mesh.triangles = triangles;
	}
}
