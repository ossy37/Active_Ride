using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSprite1 : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;

    public Sprite Sprite_BAN;
    public Sprite Sprite_PHE;
    public Sprite Sprite_UNI;

    private int Character_Num = 0;

    public GameObject SpritegameObject;

	// Use this for initialization
	void Start () {
        /*
        MainSpriteRenderer = SpritegameObject.GetComponent<SpriteRenderer>();

        Character_Number = new System.Random().Next(3);

        Debug.Log(Character_Number);

        switch (Character_Number)
        {
            case 0:
                MainSpriteRenderer.sprite = Sprite_BAN;
                break;
            case 1:
                MainSpriteRenderer.sprite = Sprite_PHE;
                break;
            case 2:
                MainSpriteRenderer.sprite = Sprite_UNI;
                break;
            default: break;
        }
        */
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
