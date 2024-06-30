using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Re : MonoBehaviour
{
    public float Max_Time;
    private float Timer = 0;
    public GameObject Pipes;
    public float Height;
    private void Update()
    {
        if(Timer> Max_Time)
        {
            GameObject New_Pipe = Instantiate(Pipes);
            New_Pipe.transform.position = transform.position + new Vector3(0, Random.Range(-Height, Height), 0);
            Destroy(New_Pipe, 15);
            Timer = 0;
        }
        Timer += Time.deltaTime;
    }
}
