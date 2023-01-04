using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlController : MonoBehaviour
{
    // Start is called before the first frame update
   
  public  void Lvl1()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void Lvl2()
    {
        SceneManager.LoadScene("lvl2");
    }

    public void Lvl3()
    {
        SceneManager.LoadScene("lvl3");
    }
}
