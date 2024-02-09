using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static GameController.LevelData;

public class LevelSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject coinPrefab;
    public GameObject redCoinPrefab;
    public GameObject greenCoinPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnLevel(GameController.LevelData level)
    {
        GameObject newLevel = new GameObject(level.name);
        newLevel.transform.position = transform.position;
        newLevel.tag = "Level";

        foreach(GameController.LevelData.Cube cube in level.cubes)
        {
            Vector3 positionOffset = new Vector3((cube.x1 + cube.x2) / 2, (cube.y1 + cube.y2) / 2, (cube.z1 + cube.z2) / 2);
            GameObject newCube = Instantiate(cubePrefab, newLevel.transform.position + positionOffset, Quaternion.Euler(cube.xRot, cube.yRot, cube.zRot), newLevel.transform);
            newCube.transform.localScale = new Vector3(cube.x2 - cube.x1, cube.y2 - cube.y1, cube.z2 - cube.z1);
        }
        foreach(GameController.LevelData.Coin coin in level.coins)
        {
            Vector3 positionOffset = new Vector3(coin.x, coin.y, coin.z);
            GameObject coinTypePrefab = null;
            switch (coin.type)
            {
                case 0:
                    coinTypePrefab = coinPrefab;
                    break;
                case 1:
                    coinTypePrefab = redCoinPrefab;
                    break;
                case 2:
                    coinTypePrefab = greenCoinPrefab;
                    break;
            }
            GameObject newCoin = Instantiate(coinTypePrefab, newLevel.transform.position + positionOffset, Quaternion.Euler(0, 0, 0), newLevel.transform);
        }
    }
}


/// <summary>Custom Editor for our PrefabSwitch script, to allow us to perform actions
/// from the editor.</summary>
[CustomEditor(typeof(LevelSpawner))]
public class LevelSpawnerEditor : Editor
{
    /// <summary>Calls on drawing the GUI for the inspector.</summary>
    public override void OnInspectorGUI()
    {
        // Draw the default inspector.
        DrawDefaultInspector();

        // Grab a reference to the target script, so we can identify it as a 
        // PrefabSwitch, instead of a simple Object.
        LevelSpawner levelSpawner = (LevelSpawner)target;

        // Create a Button for "Swap By Tag",
        if (GUILayout.Button("Spawn Test Level"))
        {
            // if it is clicked, call the SwapAllByTag method from prefabSwitch.
            GameController.LevelData testLevel = new GameController.LevelData("Test Level");
            testLevel.cubes.Add(new GameController.LevelData.Cube(0, 0, 0, 1, 2, 1));
            testLevel.coins.Add(new GameController.LevelData.Coin(-1, 0, -1, 0));
            levelSpawner.SpawnLevel(testLevel);
        }

    }
}
