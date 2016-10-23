using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CanvasRotate : MonoBehaviour {

	public List<DescriptMenu> Descript = new List<DescriptMenu>();
    public List<ButtonMenu> BtnList = new List<ButtonMenu>();

    public GameObject Axis;
	public GameObject Buttons;
	public GameObject Descriptions;

    public int Circle_val = 360;
    public int AngleParUpdate = 2;

	public int dIndex;
	public int bIndex;

	// Use this for initialization
	void Start () {
		dIndex = 0;
		bIndex = 0;
        targetRotation = transform.rotation;
	}

    public float smooth_move = 1.5f;
    private Quaternion targetRotation;

    private static float angle_z = 0;

    private void SceneManager(int index)
    {
        switch (index)
        {
            case 0:
                CameraFade.StartAlphaFade(Color.black, false, 0.3f, 0.3f, () =>
                {
                    Application.LoadLevel("Main");
                });
                break;
            case 1:
                CameraFade.StartAlphaFade(Color.black, false, 0.3f, 0.3f, () =>
                {
                    Application.LoadLevel("Main");
                });
                break;
            case 2:
                CameraFade.StartAlphaFade(Color.black, false, 0.3f, 0.3f, () =>
                {
                    Application.LoadLevel("SelectMenu");
                });
                break;
            case 3:
                CameraFade.StartAlphaFade(Color.black, false, 0.3f, 0.3f, () =>
                {
                    Application.LoadLevel("SelectMenu");
                });
                break;
            case 4:
                CameraFade.StartAlphaFade(Color.black, false, 0.3f, 0.3f, () =>
                {
                    Application.LoadLevel("SelectMenu");
                });
                break;
            default: break;

        }
    }
    private int CheckViewDescriptions(float angle)
    {
        int index = 0;
        if ((angle_z < 36) || (angle_z >= 324))
        {
            index = 0;
        }
        if ((angle_z >= 36) && (angle_z < 108))
        {
            index = 4;
        }
        if ((angle_z >= 108) && (angle_z < 180))
        {
            index = 3;
        }
        if ((angle_z >= 180) && (angle_z < 252))
        {
            index = 2;
        }
        if ((angle_z >= 252) && (angle_z < 324))
        {
            index = 1;
        }

        return index;
    }
    // Update is called once per frame
    private bool RotateFlag_plus;
    private bool RotateFlag_minus;
    private int RotatedAngle_z = 0;

    void Update () {

        //TODO: マウスホイールにも対応する?
        if (Input.GetKeyUp(KeyCode.DownArrow) ||
            (Input.GetAxis("Mouse ScrollWheel") < 0f ) )
        {
            //Descriptions.transform.Rotate(new Vector3(90, 0, 0));    
            RotateFlag_plus = true;
            //rigidbody2D.anglarVelocity();
        }
		if (Input.GetKeyUp(KeyCode.UpArrow) ||
            ( Input.GetAxis("Mouse ScrollWheel") > 0f ) )
        {
            //Buttons.transform.Rotate(Time.deltaTime, 0, 0);
            //Buttons.transform.Rotate(new Vector3(0, 0, -72) , 50f * Time.deltaTime);
            float anglez = Buttons.transform.localEulerAngles.z;
            //Debug.Log(anglez);
            targetRotation = Quaternion.Euler(0, 0 ,anglez-72);

            RotateFlag_minus = true;
        }

        angle_z = Buttons.transform.localEulerAngles.z;


        if (RotateFlag_plus)
        {
            Buttons.transform.Rotate(new Vector3(0, 0, AngleParUpdate));
            Axis.transform.Rotate(new Vector3(0, 0, -AngleParUpdate));
            RotatedAngle_z++;
        }
        if (RotateFlag_minus)
        {
            Buttons.transform.Rotate(new Vector3(0, 0, -AngleParUpdate));
            Axis.transform.Rotate(new Vector3(0, 0, AngleParUpdate));
            RotatedAngle_z++;

            //BtnList[dIndex].button.GetComponent<RectTransform>().sizeDelta =
            //    new Vector2(100 + RotatedAngle_z, 100 + RotatedAngle_z);

        }
        if (RotatedAngle_z >= Circle_val/(Descript.Count * AngleParUpdate))
        {
            RotatedAngle_z = 0;
            RotateFlag_minus = false;
            RotateFlag_plus = false;
        }


        dIndex = CheckViewDescriptions(angle_z);
        Debug.Log(dIndex);
        foreach (var d in Descript) {

            if (d.index == dIndex)
            {
                Vector3 pos = d.description.transform.position;
                if (pos.x > 0) {
                    pos.x -= 20;
                    d.description.transform.position = pos;
                }
                d.description.transform.SetAsLastSibling();
            }
            else
            {
                Vector3 pos = d.description.transform.position;
                pos.x = 500;
                d.description.transform.position = pos;
            }
        }

        //シーン遷移
        if(Input.GetKeyUp(KeyCode.Return)  || Input.GetMouseButtonUp(0))
        {
            SceneManager(dIndex);
        }

    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.01f);
    }
}

[System.Serializable]
public class DescriptMenu
{
	public GameObject description;
    public int index;
}
[System.Serializable]
public class ButtonMenu
{
    public GameObject button;
}

