using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleScript : MonoBehaviour {

    Mesh mesh;
    MeshRenderer meshRenderer;
    Vector3[] vertices;
    int[] triangles;
    public Material material;

	void Start () {
        gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = new Vector3[] {
            new Vector3(0,0,0),
            new Vector3(0,5,0),
            new Vector3(5,0,0),
        };

        mesh.triangles = new int[] { 0, 1, 2 };
        mesh.uv = new Vector2[] {new Vector2(0,0), new Vector2(0,5), new Vector2(5,0) };
 
	}
}
