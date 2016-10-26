using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour{

    SpriteRenderer MainSpriteRenderer;

    public static GameObject Obj;
    public static GameObject BANS_obj;
    public static GameObject PHEN_obj;
    public static GameObject UNIC_obj;


    //public GameObject SpritegameObject;

    public static GameObject GetGameObj()
    {
        GameObject Obj = null;
        int Character_Num = 0;

        Character_Num = new System.Random().Next(3);

        Debug.Log(Character_Num);

        switch (Character_Num)
        {
            case 0:
                Obj = BANS_obj;
                break;
            case 1:
                Obj = PHEN_obj;
                break;
            case 2:
                Obj = UNIC_obj;
                break;
            default: break;
        }

        return Obj; 
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}