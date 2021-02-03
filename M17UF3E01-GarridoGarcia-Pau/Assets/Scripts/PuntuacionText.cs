using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PuntuacionText : MonoBehaviour
{
    public string nombre;
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt(nombre) + "";
    }
}
