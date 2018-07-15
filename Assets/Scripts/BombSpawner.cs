﻿using UnityEngine;
using UnityEngine.Tilemaps; 

public class BombSpawner : MonoBehaviour {

    public Tilemap tilemap;

    public GameObject bombPrefab;
	
	// Update is called once per frame
	void Update () {
        
		if (Input.GetMouseButton(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cell = tilemap.WorldToCell(worldPos);
            Vector3 cellCenter = tilemap.GetCellCenterLocal(cell);

            Instantiate(bombPrefab, cellCenter, Quaternion.identity);
        }
	}
}
