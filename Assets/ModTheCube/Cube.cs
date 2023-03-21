using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 cubePOS = new Vector3(0, 0, 0);
    public Vector3 cubeRotate = new Vector3(30.0f, 30.0f, 30.0f);
    public int cubeScale;
    public float rotateSpeed = 3.0f;
    //public Vector4 cubeColor = new Vector4(30.0f, 30.0f, 30.0f, 30.0f);

    
    void Start()
    {
        //transform.position = new Vector3(3, 4, 1);
        transform.position = cubePOS;
        //transform.localScale = Vector3.one * 1.3f;
        cubeScale = Random.Range(1, 20);
        transform.localScale = Vector3.one * cubeScale * Time.deltaTime;
        Material material = Renderer.material;

        //material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        material.color = new Color(0.5f, 1.0f, 0.3f, Random.Range(0, 256));        
    }
    
    void Update()
    {        
        //transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        transform.Rotate(cubeRotate * rotateSpeed * Time.deltaTime);
    }
}
