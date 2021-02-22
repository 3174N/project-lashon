using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] 
public class Word
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
        MashlimPoal
    }

    #region Variables
    public wordType Type;

    public wordPurpose Purpose; 

    #endregion
}
