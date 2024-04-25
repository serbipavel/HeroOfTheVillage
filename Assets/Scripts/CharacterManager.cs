using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]SpawnPlayer sp;
    public void Play()
    {
        sp.StartGame();
    }
    public void AdventurerMale()
    {
        sp.index = 0;
    }
    public void AdventurerFemale()
    {
        sp.index = 1;
    }
    public void Punk()
    {
        sp.index = 2;
    }
    public void ArmoredFemale()
    {
        sp.index = 3;
    }
}
