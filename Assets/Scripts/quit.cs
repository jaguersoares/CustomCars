using UnityEngine;
using System.Collections;

// Quits the player when the user hits escape

public class quit : MonoBehaviour
{
    public void goQuit()
    {
        Application.Quit();
    }
}