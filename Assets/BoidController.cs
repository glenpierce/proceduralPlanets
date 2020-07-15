using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class BoidController : MonoBehaviour {

    // [HideInInspector]
    public static float visionRadius = 4.0f;
    public static float viewAngle = 270.0f;
    public bool selected = false;

    void Start() {
        
    }

    void Update() {

        Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, visionRadius);
        if (Application.IsPlaying(gameObject)) {
            // Play logic
        } else {
            Color color;
            if(selected) {
                color = Color.red;
            } else {
                color = Color.green;
            }
            foreach (var hitCollider in hitColliders) {
                if(gameObject.transform.position != hitCollider.transform.position)
                    Debug.DrawLine(gameObject.transform.position, hitCollider.gameObject.transform.position, color);
            }
        }
    }
}
