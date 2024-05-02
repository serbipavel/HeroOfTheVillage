using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportDestination; // ������ �� �����, ���� ����� ��������������� ��������
    
    public float teleportDelay = 0.5f; // �������� ����� �������������

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

        // ��� ��� �������� ������������, ���� �����

        yield return new WaitForSeconds(teleportDelay);

        // ������������ ���������
        playerTransform.position = teleportDestination.position;

        

        teleporting = false;
    }
}
