using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelBehavior : MonoBehaviour
{
    public Grid grid;
    public new SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        grid = gameObject.GetComponentInParent<Grid>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButton(0)) renderer.color = Color.black;
        else if (Input.GetMouseButton(1)) renderer.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
