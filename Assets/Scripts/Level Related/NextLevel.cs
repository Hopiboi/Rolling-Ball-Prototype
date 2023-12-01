using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Entrance")
        {
            SceneManager.LoadScene("TitleScreen");
        }

        if (collision.tag == "OutOfBounds")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

}
