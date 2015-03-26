using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class SubboardManager : MonoBehaviour {

    public int xSize = 12;
    public int ySize = 12;

    public GameObject[] floorTiles;

    void start() {
        generateBoard();
    }

    void generateBoard() {
        initFloor ();
    }

    void initFloor() {
        for(int x = 0; x < xSize; x++) {
            for(int y = 0; y < ySize; y++) {
                GameObject toInstantiate = floorTiles[Random.Range (0, floorTiles.Length)];
                GameObject instance = Instantiate (toInstantiate, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;
            }
        }
    }
}
