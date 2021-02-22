using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentence : MonoBehaviour
{
    #region Variables

    public Word[] words;

    public bool isType, isPurpose;

    public Word.wordType[] allowedTypes;
    public Word.wordPurpose[] allowedPurposes;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        Vector2 offset = new Vector2(0f, 0f);

        foreach (Word word in words)
        {
            GameObject wordObject = Instantiate(word.prefab, transform.position + (Vector3) offset, Quaternion.identity, transform);
            offset.x += wordObject.GetComponent<Collider2D>().bounds.size.x;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
