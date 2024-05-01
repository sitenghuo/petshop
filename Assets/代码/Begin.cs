using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        IEnumerator Dialo_1()
        {
            yield return new WaitForSeconds(3f);

            
        }

        if(index == 0)
        {
            StartCoroutine(Dialo_1());
        }
    }
}
