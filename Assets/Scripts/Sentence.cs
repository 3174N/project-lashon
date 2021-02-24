using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Sentence : MonoBehaviour
{
    #region Variables

    public Word[] words;
    [SerializeField] private List<Word> allowedWords = new List<Word>();

    public bool isType, isPurpose;

    public Word.wordType[] allowedTypes;
    public Word.wordPurpose[] allowedPurposes;

    #endregion

    // Start is called before the first frame update
    private void Start()
    {
        InitializeSentence();
    }

    /// <summary>
    /// Initialize sntence with words and triggered colliders (when necessery)
    /// </summary>
    private void InitializeSentence()
    {
        foreach (Transform child in transform)
        {
            DestroyImmediate(child.gameObject);
        }

        Vector2 offset = new Vector2(0f, 0f);

        foreach (Word word in words)
        {
            GameObject wordObject = Instantiate(word.prefab, transform.position + (Vector3) offset, Quaternion.identity, transform);
            offset.x += wordObject.GetComponent<Collider2D>().bounds.size.x;

            if (isType)
            {
                if (allowedTypes.Contains(word.type))
                {
                    allowedWords.Add(word);
                }
                else
                {
                    wordObject.GetComponent<BoxCollider2D>().isTrigger = true;
                }
            } 
            else
            {
                if (allowedPurposes.Contains(word.purpose))
                {
                    allowedWords.Add(word);
                }
                else
                {
                    wordObject.GetComponent<BoxCollider2D>().isTrigger = true;
                }
            }
        }
    }
}
