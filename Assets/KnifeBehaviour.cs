using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBehaviour : MonoBehaviour
{
    public GameObject Mugger;
    public GameObject Knife;
    public Camera MainCam;

    // Update is called once per frame
    void Update()
    {
        Vector3 centerPoint = Mugger.GetComponent<SpriteRenderer>().bounds.center;
        Vector3 mousePos = MainCam.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - centerPoint.y, mousePos.x - centerPoint.x);
        Knife.transform.localPosition = new Vector3(1.5f * Mathf.Cos(angle), 1.5f * Mathf.Sin(angle), 0);
        Knife.transform.eulerAngles = new Vector3(0, 0, (angle * 180 / Mathf.PI) - 90);
    }
}
