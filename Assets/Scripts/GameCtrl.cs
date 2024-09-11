using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MonoBehaviour
{
    [SerializeField]
    GameObject nodeDrumStick;
    [SerializeField]
    List<AudioClip> listAudioSources = new List<AudioClip>();

    private void Start()
    {
        //var v = new Vector3(75, 0, 0);
        //nodeDrumStick.transform.rotation = Quaternion.Euler(v);
    }

    // Start is called before the first frame update
    public bool CheckIsTouchMuyu()
    {
        Ray _ray;
        RaycastHit _hit;
        Vector2 posTouch = Input.mousePosition;
        _ray = Camera.main.ScreenPointToRay(posTouch);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(_ray, out _hit, 100f) && _hit.transform.gameObject.name == "muyu")
            {
                //Debug.Log(_hit.transform.gameObject.name == "muyu");
                Debug.Log("Is muyu");
                return true;
            }

        }
        return false;
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("fuckingshiet");
        //if (collision.collider.GetType() == typeof(BoxCollider))
        //{
        //    //Do whatever
        //}
    }

    void RunSoundTouch()
    {
        var obj = GameObject.Find("touchMuyu");
        if (obj != null)
        {
            obj.GetComponent<AudioSource>().Play();
            return;
        }
        obj = new GameObject();
        obj.name = "touchMuyu";
        obj.transform.SetParent(this.transform);
        obj.AddComponent<AudioSource>();
        obj.GetComponent<AudioSource>().clip = this.listAudioSources[1];
        obj.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckIsTouchMuyu())
        {
            this.RunSoundTouch();
        }
        //var newPos = new Vector3(this.nodeDrumStick.transform.position.x, this.nodeDrumStick.transform.position.y, this.nodeDrumStick.transform.position.z);
        //newPos.y = newPos.y - 0.005f;
        //this.nodeDrumStick.transform.position = newPos;
    }
}

enum SoundName
{
    Bgm = 0,
    ClickMuyu = 1
}