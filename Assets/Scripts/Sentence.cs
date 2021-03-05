using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Sentence : MonoBehaviour
{
    #region Variables

    public WordToObject[] words;

    #endregion

    // Start is called before the first frame update
    private void Start()
    {
        InitializeSentence();
    }

    /// <summary>
    /// Initialize sentence with words and triggered colliders (when necessary)
    /// </summary>
    private void InitializeSentence()
    {
        for (int i = 0; i < words.Count(); i++)
        {
            Word word = words[i].word;

            word.parent = this;
            word.index = i;
        }
    }
}
