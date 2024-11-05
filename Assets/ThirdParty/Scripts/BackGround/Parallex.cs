using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallex : MonoBehaviour
{
    Material mat;
    float distance;

    [Range(0f, 0.5f)]
    public float speed=0.2f;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        distance += Time.deltaTime * speed;
        mat.mainTextureOffset = new Vector2(distance, 0);

    }
}