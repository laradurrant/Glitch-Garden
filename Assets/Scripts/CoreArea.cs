using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreArea : MonoBehaviour {
    float x, y;
    public GameObject defender;

    private void OnMouseDown()
    {
        SpawnDefender();
    }

    private Vector2 GetSquareClicked()
    {
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;

        Vector2 m_position = new Vector2(x, y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(m_position);

        worldPos = SnapToGrid(worldPos);

        return worldPos;
    }

    private Vector2 SnapToGrid(Vector2 worldPos)
    {
        worldPos.x = Mathf.Round(worldPos.x);
        worldPos.y = Mathf.Round(worldPos.y);

        return worldPos;
    }

    private void SpawnDefender()
    {
      //  Debug.Log("Spawning defender.");
        
        GameObject newDefender = Instantiate(defender, GetSquareClicked(), Quaternion.identity);
    }

}
