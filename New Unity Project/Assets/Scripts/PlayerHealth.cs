using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 3;
    public GameObject[] hearts;
    private PlayerControl playerControl;

    void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("Heart");
        foreach (GameObject heart in hearts)
        {
            heart.SetActive(true);
        }
        playerControl = GetComponent<PlayerControl>();
    }


    public void TakeDamage(int amount)
    {
        Health -= amount;
        hearts[Health].SetActive(false);
        //Debug.Log(Health);

        if (Health <= 0)
        {
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("GameOver");
    }
}
