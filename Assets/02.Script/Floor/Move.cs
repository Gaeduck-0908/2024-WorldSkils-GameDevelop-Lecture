using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using lib;
using UnityEngine.UI;

public class Move : Singleton<Move>
{
    // 속도 비교를 위한 변수
    private GameObject speed_text;

    private float speed;
    private void Start()
    {
        speed = 5.0f;
        speed_text = this.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject; 
    }

    private void Update()
    {
        this.gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
        speed_text.GetComponent<Text>().text = speed.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "sand":
                speed = 2.5f;
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "sand":
                speed = 5.0f;
                break;
        }
    }
}