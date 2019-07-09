using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class about : MonoBehaviour
{
   public void Loadmenu(string menu)
    {
        SceneManager.LoadScene(menu);
    }
}
