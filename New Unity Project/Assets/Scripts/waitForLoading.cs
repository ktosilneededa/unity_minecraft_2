using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waitForLoading : MonoBehaviour
{
    public Text loadingText;
    private PlayerControl playerControl;
    private GameObject[] enemy;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerControl = player.GetComponent<PlayerControl>();
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        playerControl.enabled = false;
        player.GetComponent<Rigidbody>().useGravity = false;
        foreach (GameObject e in enemy)
        {
            e.GetComponent<ShrekController>().enabled = false;
            e.GetComponent<Rigidbody>().useGravity = false;
        }

        StartCoroutine(Waiting());
    }

    // Update is called once per frame
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(4);

        playerControl.enabled = true;
        player.GetComponent<Rigidbody>().useGravity = true;
        foreach (GameObject e in enemy)
        {
            e.GetComponent<ShrekController>().enabled = true;
            e.GetComponent<Rigidbody>().useGravity = true;
        }

        Destroy(loadingText.gameObject);
    }
}
