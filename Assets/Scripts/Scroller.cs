using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float scrollSpeed;
    MeshRenderer mr;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(Time.time * scrollSpeed, 0);
        mr.material.mainTextureOffset = offset;
    }
}
