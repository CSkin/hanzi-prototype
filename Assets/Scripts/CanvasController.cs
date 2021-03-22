using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject pixelPrefab;
    public int gridSize = 10;

    // Start is called before the first frame update
    void Start()
    {
        Grid grid = gameObject.GetComponent<Grid>();

        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                Vector3Int cellPosition = new Vector3Int(x, y, 0);
                Vector3 worldPosition = grid.GetCellCenterWorld(cellPosition);
                Instantiate(pixelPrefab, worldPosition, Quaternion.identity, transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
