using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Pertanyaan : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tempatTeks = null;
    [SerializeField] private TextMeshProUGUI _judul = null;
    [SerializeField] private Image _tempatGambar = null;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Isi tempat teks yaitu:");
        Debug.Log(_tempatTeks.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPertanyaan(string judul, string teksPertanyaan, Sprite gambarHint) {
        _tempatTeks.text = teksPertanyaan;
        _tempatGambar.sprite = gambarHint;
        _judul.text = judul;
    }
}
