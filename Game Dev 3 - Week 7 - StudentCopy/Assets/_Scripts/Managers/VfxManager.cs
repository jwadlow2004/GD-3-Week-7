using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Singleton;

namespace GameDevWithMarco.Managers
{
    public class VfxManager : Singleton<VfxManager>
    {
        // Start is called before the first frame update
       public void HitStop(float stopDuration)
       {
         StartCoroutine(HitStopCoroutine(stopDuration));
       }

        // Update is called once per frame
        IEnumerator HitStopCoroutine(float duration)
        {
            Time.timeScale = 0;

            yield return new WaitForSeconds(duration);  
            //test
            Time.timeScale = 1;
        }
    }
}
