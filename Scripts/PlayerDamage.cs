using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    private bool immortal = false;
    public int hp = 3;
    public PlayerDamage()
    {

    }
    public void GetDamage()
    {
        if (immortal == false)
        {
            immortal = true;
            hp--;
            if (hp <= 0)
                SceneManager.LoadScene(1);
            StartCoroutine(Immortal());
        }

    }

    IEnumerator Immortal()
    {
        for (int i = 0; i < 3; i++)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(0.5f);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(1);
        immortal = false;
    }


}
