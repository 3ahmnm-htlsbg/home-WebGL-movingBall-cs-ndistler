using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomBallPos : MonoBehaviour
{
    [SerializeField] private GameObject[] ballPositions;
    int randomInt;
    int randomIntBefore;
    public GameObject Ball;


    void start()
    {
        randomInt = 0;
        randomIntBefore = 5;
    }

    public void getRandomInt()
    {
        randomInt = Random.Range(0, 4);
        if (randomInt != randomIntBefore)
        {
            randomIntBefore = randomInt;
            setPosition();
        }
        else
        {
            getRandomInt();
        }
    }

    public void setPosition()
    {
        Ball.transform.position = ballPositions[randomInt].transform.position;
    }

}

