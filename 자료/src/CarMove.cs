using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    private int speed_Lv;
    private float now_speed = 5;

    private void Start()
    {
        speed_Lv = 1;
    }
    
    private void Update()
    {
      if(Input.GetKey(KeyCode.W))
      {
        now_speed += speed_Lv * 2 * Time.deltaTime;
      }
      this.gameObject.transform.Translate(Vector2.up * now_speed * Time.deltaTime);

      if(Input.GetKeyDown(KeyCode.UpArrow))
      {
          speed_Lv++;
      }
      else if (Input.GetKeyDown(KeyCode.DownArrow))
      {
          speed_Lv--;
      }
    }
}
