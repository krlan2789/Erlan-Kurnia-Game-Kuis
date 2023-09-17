using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour
{
    [SerializeField] private UI_PesanLevel _tempatPesan = null;
    [SerializeField] private Slider _timeBar = null;
    [SerializeField] private float _waktuJawab = 30;
    private float _sisaWaktu = 0;
    private bool _waktuBerjalan = false;

    public bool WaktuBerjalan {
        get => _waktuBerjalan;
        set => _waktuBerjalan = value;
    }

    private void Start() {
        UlangiWaktu();
        _waktuBerjalan = true;
    }

    private void Update() {
        if (!_waktuBerjalan) return;

        _sisaWaktu -= Time.deltaTime;
        _timeBar.value = _sisaWaktu / _waktuJawab;

        if (_sisaWaktu <= 0) {
            Debug.Log("Waktu Habis");
            _tempatPesan.Pesan = "Waktu Habis";
            _tempatPesan.gameObject.SetActive(true);
            _waktuBerjalan = false;
            return;
        }

        Debug.Log(_sisaWaktu);
    }

    public void UlangiWaktu() {
        _sisaWaktu = _waktuJawab;
    }
}
