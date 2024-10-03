using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f , minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hour, min, sec;

   
   // Awake is called before the first frame update
   
    void Awake() {
        var time = DateTime.Now;
        // Debug.Log(DateTime.Now.Hour);
        hour.localRotation =
             Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
        min.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
        sec.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }
   

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        // Debug.Log(DateTime.Now.Hour);
        hour.localRotation =
             Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        min.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        sec.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }


}

