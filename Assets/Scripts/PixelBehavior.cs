using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelBehavior : MonoBehaviour
{
    void OnMouseDown()
    {
        Grid grid = gameObject.GetComponentInParent<Grid>();
        Debug.Log("Drawing at " + grid.WorldToCell(transform.position));

        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.color = Color.black;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
