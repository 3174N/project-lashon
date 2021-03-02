﻿using System.Collections;
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
        MashlimPoal,
        Hesger,
        Pnia,
        Kria
    }

    #region Variables

    public wordType type;

    public wordPurpose purpose;

    public GameObject prefab;

    #endregion
}
