using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    float scrollSpeed;
    public float scrollMultiplier;
    MeshRenderer mr;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        scrollSpeed = GameManager.gm.gameSpeed; 
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(Time.time * scrollSpeed * scrollMultiplier, 0);
        mr.material.mainTextureOffset = offset;
    }
}
