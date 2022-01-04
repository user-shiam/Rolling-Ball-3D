using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{

    private IEnumerator OnCollisionEnter(Collision c)
    {
      if(c.gameObject.name=="Sphere")
      yield return new WaitForSeconds(0.20f);
      SceneManager.LoadScene("Main");

    }
       

}
