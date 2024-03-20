using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Image_Fill : MonoBehaviour
{
    private void Update()
    {
        StartCoroutine(cycle());
    }

    IEnumerator cycle()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (float i = 1f; i >= 0; i -= 0.05f)
            {
                this.gameObject.GetComponent<Image>().fillAmount = i;
                yield return new WaitForSeconds(0.01f);
            }
            this.gameObject.GetComponent<Image>().fillAmount = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (float i = 0f; i <= 1; i += 0.05f)
            {
                this.gameObject.GetComponent<Image>().fillAmount = i;
                yield return new WaitForSeconds(0.01f);
            }
            this.gameObject.GetComponent<Image>().fillAmount = 1;
        }
    }

}
