using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileManager : MonoBehaviour
{

    public GameObject[] TilePrefabs;

    private Transform PlayerTransform;
    private float SpawnZ = 0.0f;
    private float TileLength = 30.0f;
    public int TileAmount = 10;
    private float SafeZone = 70.0f;
    private int LastPrefabIndex = 0;

    private List<GameObject> ActiveTiles;

    // Start is called before the first frame update
    void Start()
    {
        ActiveTiles = new List<GameObject>();
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
        for(int i = 0; i < TileAmount; i++)
        {
            if (i < 2)
                SpawnTile(0);
            else
                SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerTransform.position.z - SafeZone > (SpawnZ - TileAmount * TileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }

    void SpawnTile(int PrefabIndex = -1)
    {
        GameObject go;

        if (PrefabIndex == -1)
            go = Instantiate(TilePrefabs[RandomPrefabIndex()]) as GameObject;
       

        else
            go = Instantiate(TilePrefabs[PrefabIndex]) as GameObject;

        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * SpawnZ;
        SpawnZ += TileLength;
        ActiveTiles.Add(go);
    }

    void DeleteTile()
    {
        Destroy(ActiveTiles[0]);
        ActiveTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (TilePrefabs.Length <= 1)
            return 0;

        int RandomIndex = LastPrefabIndex;
        while(RandomIndex == LastPrefabIndex)
        {
            RandomIndex = Random.Range(0, TilePrefabs.Length);
        }

        LastPrefabIndex = RandomIndex;
        return RandomIndex;
    }

}
