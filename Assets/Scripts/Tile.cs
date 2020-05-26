using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Tile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        transform.DOPunchScale(Vector3.one, 1f);
    }
}
