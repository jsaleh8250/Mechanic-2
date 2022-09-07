using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // This will disable the other players move script on mouse click
    public GameObject otherPlayer;
    private void OnMouseDown()
    {
        otherPlayer.GetComponent<Move>().enabled = false;
        GetComponent<Move>().enabled = true;
    }
}
