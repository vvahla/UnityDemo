using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public bool movementLocked = true;

    public GameObject dissolveGeo;
    public GameObject swordSpawner;
    public GameObject portal;
    public GameObject greetings;
    public GameObject snow;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CameraRotation());
    }

    // Update is called once per frame
    void Update()
    {

        if(!movementLocked)
            transform.Translate(new Vector3(0, 0, 5 * Time.deltaTime));

        //DEBUG
        /*if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector3(0, 0, 10 * Time.deltaTime));
        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector3(-1 * Time.deltaTime, 0, 0));
        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector3(0, 0, -1 * Time.deltaTime));
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector3(1 * Time.deltaTime, 0, 0));
            */
    }

    public IEnumerator CameraRotation()
    {
        yield return new WaitForSeconds(4);
        movementLocked = false;
        yield return new WaitForSeconds(7.5f);
        dissolveGeo.SetActive(true);
        yield return new WaitForSeconds(8);
        portal.SetActive(true);
        swordSpawner.SetActive(true);
        yield return new WaitForSeconds(58.5f);
        movementLocked = true;
        greetings.SetActive(true);
        snow.SetActive(true);
        yield return new WaitForSeconds(15f);
        Application.Quit();
        yield return null;
    }
}
