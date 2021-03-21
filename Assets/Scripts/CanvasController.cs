using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject pixelPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Save reference to canvas grid
        Grid grid = gameObject.GetComponent<Grid>();

        // Which grid cell to render into
        Vector3Int cellPosition = new Vector3Int (0, 0, 0);

        // Convert grid coords to world position
        Vector3 worldPosition = grid.CellToWorld(cellPosition);

        // Instatiate the pixel
        Instantiate(pixelPrefab, worldPosition, Quaternion.identity, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
