using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangePrefab : MonoBehaviour{

    SpriteRenderer MainSpriteRenderer;

    public GameObject Obj;
    public GameObject BANS_obj;
    public GameObject PHEN_obj;
    public GameObject UNIC_obj;

    private int Character_Num = 0;

    public GameObject SpritegameObject;

    public GameObject GetGameObj()
    {
        GameObject Obj = null;

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
            default:
                Obj = BANS_obj;
                break;
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