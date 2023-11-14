using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPrefabs;
    private Touch touch;
    private Vector2 touchPos;
    private int index = -1;

    // Update is called once per frame
    void Update()
    {
        //Register touch on screen
        if(Input.touchCount > 0) {
            touch = Input.GetTouch(0);
            touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            //When first touch beings, start to iterate through array
            if(touch.phase == TouchPhase.Began) {
                index += 1;
                if(index == spawnPrefabs.Length) {
                    index = 0; //Reset index to start of array
                }
                for (int i = 0; i < spawnPrefabs.Length; i++) {
                    if(i == index) {
                        Instantiate(spawnPrefabs[i], touchPos, Quaternion.identity);
                    }
                }
            }
        }
    }
}
