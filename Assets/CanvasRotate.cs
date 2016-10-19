using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CanvasRotate : MonoBehaviour {

	public List<DescriptMenu> Descript = new List<DescriptMenu>();

	public GameObject Buttons;
	public GameObject Descriptions;

	public int dIndex;
	public int bIndex;

	// Use this for initialization
	void Start () {
		dIndex = 0;
		bIndex = 0;

	}

    private static float angle_z = 0;
    private int CheckViewDescriptions(float angle)
    {
        int index = 0;
        if ((angle_z < 36) || (angle_z >= 324))
        {
            index = 0;
        }
        if ((angle_z >= 36) && (angle_z < 108))
        {
            index = 1;
        }
        if ((angle_z >= 108) && (angle_z < 180))
        {
            index = 2;
        }
        if ((angle_z >= 180) && (angle_z < 252))
        {
            index = 3;
        }
        if ((angle_z >= 252) && (angle_z < 324))
        {
            index = 4;
        }

        return index;
    }
    // Update is called once per frame
    void Update () {

        //TODO: マウスホイールにも対応する?
        if (Input.GetKey(KeyCode.DownArrow)) {
			Buttons.transform.Rotate(new Vector3(0, 0, 5));
            //Descriptions.transform.Rotate(new Vector3(90, 0, 0));    
            

		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			Buttons.transform.Rotate(new Vector3(0, 0, -5));    
			//Descriptions.transform.Rotate(new Vector3(90, 0, 0));    

		}
        angle_z = Buttons.transform.localEulerAngles.z;
        dIndex = CheckViewDescriptions(angle_z);
        Descript[dIndex].description.transform.SetAsLastSibling();

    }
}

[System.Serializable]
public class DescriptMenu
{
	public GameObject description;
}

