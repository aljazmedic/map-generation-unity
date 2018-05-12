using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public Texture2D map;
    public ColorToPrefab[] Mappings;
    public float scale;

    void Start()
    {
        GameObject levelTiles = new GameObject("LevelTiles");
        Instantiate(levelTiles);
        GenerateLevel(levelTiles);
    }

    private void GenerateLevel(GameObject levelTiles)
    {
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateTile(x, y, levelTiles);
            }
        }
    }

    void GenerateTile(int x, int y, GameObject parent){
        Color pixelColor = map.GetPixel(x, y);

        if (pixelColor.a == 0)
        {
            //transparent
            return;
        }

        for (int i = 0; i < Mappings.Length; i++)
        {
            if (pixelColor.Equals(Mappings[i].color))
            {
                Instantiate(Mappings[i].prefab, new Vector3(x * scale, 0, y * scale), Quaternion.identity, parent.transform);
                return;
            }
        }
    }
}
