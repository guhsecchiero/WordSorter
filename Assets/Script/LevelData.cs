using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData {

    public int levelIndex;

    public LevelData (GameManager gameManager)
    {
        levelIndex = gameManager.activeScene;
    }
     
}
