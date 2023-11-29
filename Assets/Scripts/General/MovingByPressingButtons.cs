using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingByPressingButtons : MonoBehaviour
{

    [SerializeField] private GameObject openingHatch;
    [SerializeField] private float speedObject = 4f; //Speed to open the hatch
    [SerializeField] private float hatchPosition = 15f; //Position of the hatch when its open

    public void OpeningTheHatch()
    {
        //new variable to hold. Position of Game object X, New Position, Speed to do the position
        float newHatchPositionX = Mathf.MoveTowards(openingHatch.transform.position.x, hatchPosition, speedObject * Time.deltaTime);

        //new Vector 2 of X but the Y is in the same position
        openingHatch.transform.position = new Vector2(newHatchPositionX, openingHatch.transform.position.y);

        Debug.Log(newHatchPositionX);
    }

}
