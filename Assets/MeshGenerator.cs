using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour {

    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;


    void Start() {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        createShape();
        updateMesh();
    }

    void createShape() {
        vertices = new Vector3[] {
            new Vector3(0,0,0),
            new Vector3(0,0,1),
            new Vector3(1,0,0)
        };

        triangles = new int[] {
            0,1,2
        };
    }

    void updateMesh() {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}
