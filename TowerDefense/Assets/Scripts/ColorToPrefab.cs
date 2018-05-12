using UnityEngine;

[System.Serializable]
public class ColorToPrefab  {
    public Color color;
    public GameObject prefab;

    ColorToPrefab(Color col, GameObject pref)
    {
        color = col;
        prefab = pref;
    }

}
