using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSoundControler : MonoBehaviour {

    public AudioClip cubeSound;

    //衝突したオブジェクトのタグがground or Cubeだったら音を1にする。
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "ground")
        {
            AudioSource.PlayClipAtPoint(cubeSound, transform.position);
        }

        if (collision.gameObject.tag == "CubePrefab")
        {
            AudioSource.PlayClipAtPoint(cubeSound, transform.position);
        }
    }

}
