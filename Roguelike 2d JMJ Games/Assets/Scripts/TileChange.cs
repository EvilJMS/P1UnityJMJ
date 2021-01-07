using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class TileChange : MonoBehaviour
{
    public List<TilemapRenderer> tileMapList;
    // Start is called before the first frame update
    void Start()
    {
      switch (SceneManager.GetActiveScene().name) {
        case "NIvel1":
          tileMapList[0].enabled=true;
          tileMapList[1].enabled=false;
          tileMapList[2].enabled=false;
          break;
        case "Nivel2":
          tileMapList[0].enabled=false;
          tileMapList[1].enabled=true;
          tileMapList[2].enabled=false;
          break;
        case "Nivel3":
          tileMapList[0].enabled=false;
          tileMapList[1].enabled=false;
          tileMapList[2].enabled=true;
          break;
        case "Tutorial":
          tileMapList[0].enabled=true;
          tileMapList[1].enabled=false;
          tileMapList[2].enabled=false;
          break;
        case "Hub":
          tileMapList[0].enabled=true;
          tileMapList[1].enabled=false;
          tileMapList[2].enabled=false;
          break;
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
