using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject grid;
    public GameObject tilePrefab;

    private int cols = 10;
    private int rows = 10;

    // Start is called before the first frame update
    void Start()
    {
        float w = 1f / cols;
        float h = 1f / rows;

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                var tile = Instantiate(tilePrefab, grid.transform);
                float normalizedX = w * j + w / 2;
                float normalizedY = h * i + h / 2;

                float worldX = (normalizedX) - (w*cols / 2f);
                float worldY = (normalizedY) - (h*rows / 2f);

                // ------------
                float betterX = (-w * cols / 2) + (w * j) + (w / 2);
                float betterY = (-h * rows / 2) + (h * i) + (h / 2);
                // ------------

                //tile.transform.localPosition = new Vector3(normalizedX, normalizedY, -1);
                tile.transform.localPosition = new Vector3(worldX, worldY, -1);

                //tile.transform.localPosition = new Vector3(betterX, betterY, -1);
                tile.transform.localScale = new Vector3(w, h, 1);
                tile.GetComponentInChildren<TextMeshPro>().text = $"({i},{j})";
            }
    }

}
