using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Sentence : MonoBehaviour
{
    #region Variables

    public WordToObject[] words;
    [SerializeField] private List<Word> allowedWords = new List<Word>();

    public bool isType, isPurpose;

    public Word.wordType allowedType;
    public Word.wordPurpose allowedPurpose;

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
        allowedWords.Clear();
        foreach (Transform child in transform)
        {
            DestroyImmediate(child.gameObject);
        }

        Vector2 offset = new Vector2(0f, 0f);

        for (int i = 0; i <= words.Count(); i++)
        {
            Word word = words[i].word;

            word.parent = this;
            word.index = i;

            GameObject wordObject = Instantiate(word.gameObject, transform.position - (Vector3)offset, Quaternion.identity, transform);
            offset.x -= wordObject.GetComponent<Collider2D>().bounds.size.x;

            if (isType)
            {
                if (allowedType == word.type)
                {
                    allowedWords.Add(word);
                    transform.GetChild(i).GetComponent<Word>().isCorrect = true;
                }
                else
                {
                    transform.GetChild(i).GetComponent<Word>().isCorrect = false;
                }
            }
            else
            {
                if (allowedPurpose == word.purpose)
                {
                    allowedWords.Add(word);
                    transform.GetChild(i).GetComponent<Word>().isCorrect = true;
                }
                else
                {
                    transform.GetChild(i).GetComponent<Word>().isCorrect = false;
                }
            }
        }
    }
}
