using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    private int[] numbers = { 2, 3, 3, 4, 4, 5, 5, 6, 6, 8, 8, 9, 9, 10, 10, 11, 11, 12 };

    void Start()
    {
        ShuffleTiles();
        ShuffleNumbers();
        PlaceNumAndTiles();
    }

    //shuffles the tiles for random placement
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

    //shuffles the numbers for random placements
    private void ShuffleNumbers()
    {
        for (int i = numbers.Length - 1; i > 0; i--)
        {
            var r = Random.Range(0, i);
            int tmp = numbers[i];
            numbers[i] = numbers[r];
            numbers[r] = tmp;
        }
    }

    //places the tiles and the numbers that go with it
    private void PlaceNumAndTiles()
    {
        int numTileCount = 0;
        for (int i = 0; i < tiles.Length; i++)
        {
            GameObject tile = Instantiate(tiles[i], tileLocations[i].position, tileLocations[i].rotation);
            //print(tiles[i].name);
            if (tiles[i].name != "Desert Tile")
            {
                GameObject text = tile.transform.GetChild(1).GetChild(0).gameObject;
                TMP_Text numberTile = text.GetComponent<TMP_Text>();

                numberTile.text = numbers[numTileCount].ToString();
                if (numbers[numTileCount] == 6 || numbers[numTileCount] == 8)
                {
                    text.GetComponent<TextMeshProUGUI>().faceColor = Color.red;
                }
                numberTile.autoSizeTextContainer = true;
                numTileCount++;

            }
            tile.transform.SetParent(tileLocations[i]);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
