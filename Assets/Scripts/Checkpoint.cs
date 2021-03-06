using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    #region Variables

    public bool isFlag = false;

    #endregion

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player != null)
        {
            if (isFlag)
            {
                LevelLoader.LoadNextLevel();
            }
            else
            {
                player.SetChechpoint(transform);
            }
        }
    }
}
