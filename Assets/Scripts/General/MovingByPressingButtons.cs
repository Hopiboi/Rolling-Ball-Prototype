using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingByPressingButtons : MonoBehaviour
{
    [Header ("Opening Hatch System")]
    [SerializeField] private GameObject openingHatch;
    [SerializeField] private float speedObject = 4f; //Speed to open the hatch
    [SerializeField] private Vector2 hatchPosition = new Vector2 (-9.528f, 4.9f); //Position of the hatch when its open
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void HatchAnimation()
    {
        //start the coroutine or the time to move the object
        StartCoroutine(OpeningTheHatch(hatchPosition));
        gameManager.isCanDraw = true;
    }
    // -9.528 ,4.9

    IEnumerator OpeningTheHatch(Vector2 target)
    {
        //Distance is the one that moves the position, distance of Game Object and target, more than 0.01f
        while (Vector2.Distance(openingHatch.transform.position, target) > 0.01f)
        {
            //Game object. Position of Game object X, New Position, Speed to do the position
            openingHatch.transform.position = Vector2.MoveTowards(openingHatch.transform.position, target, speedObject * Time.deltaTime);
            yield return null;
            //return one frame
        }

    }

}
