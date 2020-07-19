using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [ExecuteAlways]
public class MoonShader : MonoBehaviour {

    public ComputeShader computeShader;

    void Start() {
        
    }

    void Update() {
        runShader();
    }

    void runShader() {
        int kernelHandle = computeShader.FindKernel("CSMain");

        // RenderTexture tex = new RenderTexture(256,256,24);
        // tex.enableRandomWrite = true;
        // tex.Create();

        // computeShader.SetTexture(kernelHandle, "Result", tex);
        // computeShader.Dispatch(kernelHandle, 256/8, 256/8, 1);
        computeShader.Dispatch(kernelHandle, 512, 1, 1);
    }
}
