using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] GameObject[] players;
    [SerializeField] GameObject cameraToOff;
    [SerializeField] Canvas canvas;
    GameObject player;
    public int index = 0;
    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        
    }
    public void StartGame()
    {
        Instantiate(players[index], transform.position, Quaternion.identity);
        cameraToOff.SetActive(false);
        canvas.enabled = false;

    }
}
