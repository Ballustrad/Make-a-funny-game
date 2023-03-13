using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{


    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
