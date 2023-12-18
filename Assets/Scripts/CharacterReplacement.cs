using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterReplacement : MonoBehaviour
{

    public GameObject newCharacterPrefab;
    // Start is called before the first frame update
    void Start()
    {
        ReplaceCharacter();

    }
    void ReplaceCharacter()
    {
        GameObject newCharacter = Instantiate(newCharacterPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
