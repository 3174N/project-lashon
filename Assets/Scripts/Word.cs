using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word : MonoBehaviour
{
    public enum wordType
    {
        Noun,
        Verb,
        Adjactive
    }

    public enum wordPurpose
    {
        Nose,
        Nasu,
        MashlimShem,
        MashlimPoal,
        Hesger,
        Pnia,
        Kria
    }

    #region Variables

    public wordType type;

    public wordPurpose purpose;

    public bool isCorrect = false;

    [HideInInspector] public Sentence parent;
    [HideInInspector] public int index;

    #endregion

    private void OnMouseDown()
    {
        if (isCorrect)
        {
            Debug.Log("Correct!");

            parent.words[index].animationSubject.SetTrigger("Start");
        }
        else
        {
            Debug.Log("Wrong!");
        }
    }
}
