using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    public Transform[] tileLocations;
    private int desert = 1;
    private int brick = 3;
    private int ore = 3;
    private int sheep = 4;
    private int wheat = 4;
    private int forest = 4;
    public GameObject[] tiles;

    void Start()
    {
        ShuffleTiles();
        for(int i = 0; i < tiles.Length; i++)
        {
            GameObject tile = Instantiate(tiles[i], tileLocations[i].position, tileLocations[i].rotation); ;
            tile.transform.SetParent(tileLocations[i]);
        }
    }


    private void ShuffleTiles()
    {
        for (int i = tiles.Length- 1; i > 0; i--)
        {
            var r = Random.Range(0, i);
            GameObject tmp = tiles[i];
            tiles[i] = tiles[r];
            tiles[r] = tmp;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
