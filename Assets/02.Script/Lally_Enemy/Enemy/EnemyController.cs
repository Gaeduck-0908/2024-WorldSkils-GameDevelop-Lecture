using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using lib;

public class EnemyController : Singleton<EnemyController>
{
    [SerializeField]
    private Transform[] Lally_point;
    private int Now_point;
    private int Max_point;

    private float Move_Speed;

    private void Start()
    {
        Move_Speed = 13.0f;
        StartCoroutine(set_point());
        StartCoroutine(check_point());
    }

    private void Update()
    {
        if (Now_point != Max_point)
        {
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, Lally_point[Now_point].transform.position, Move_Speed * Time.deltaTime);
        }
    }

    IEnumerator set_point()
    {
        Now_point = 0;
        Max_point = Lally_point.Length;
        this.gameObject.transform.position = Lally_point[Now_point].position;
        yield return new WaitForSeconds(3.0f);
    }

    IEnumerator check_point()
    {
        while(true)
        {
            if (Now_point == Max_point)
            {
                Now_point = 0;
            }
            else if (this.gameObject.transform.position == Lally_point[Now_point].position)
            {
                Now_point++;
            }
            yield return null;
        }
    }
}
