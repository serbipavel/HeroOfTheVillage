using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportDestination; // Ссылка на точку, куда нужно телепортировать персонаж
    
    public float teleportDelay = 0.5f; // Задержка перед телепортацией

    private bool teleporting = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !teleporting)
        {
            StartCoroutine(Tp(other.transform));
        }
    }

    IEnumerator Tp(Transform playerTransform)
    {
        teleporting = true;

        // Ваш код анимации телепортации, если нужен

        yield return new WaitForSeconds(teleportDelay);

        // Телепортация персонажа
        playerTransform.position = teleportDestination.position;

        

        teleporting = false;
    }
}
