using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // 이차원 배열 구조
    //    Tile[,] m_TilesArray = new Tile[6, 6];

    // 사전 구조<key, value>
    Dictionary<string,Tile> m_TileDictionary = new Dictionary<string, Tile>();

    // Start is called before the first frame update
    void Start()
    {
        GameObject tilePrefab = Resources.Load("Prefabs/CandyPurple") as GameObject;
        Tile tile_0 = Instantiate<Tile>(tilePrefab.transform.GetComponent<Tile>());
        
        tile_0.transform.position = Vector3.zero;

        //타일의 부모를 Board로 설정해야 보임
        tile_0.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
