using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    private bool immortal = false;
    public Text myText;
    public int hp = 3;
    private void Start()
    {
        myText.text = "HP: " + hp.ToString();
    }
    public void GetDamage()
    {
        if (immortal == false)
        {
            immortal = true;
            hp--;
            if (hp <= 0)
                SceneManager.LoadScene(1);
            myText.text = "HP: " + hp;
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
