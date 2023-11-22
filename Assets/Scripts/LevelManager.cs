using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //[System.Serializable]
    //private struct DataSoal {
    //    public Sprite hint;
    //    public string pertanyaan;
    //    public string[] jawabanTeks;
    //    public bool[] adalahBenar;
    //}
    //[SerializeField] private DataSoal[] _soalSoal = new DataSoal[0];

    [SerializeField] private LevelPackKuis _soalSoal = null;
    [SerializeField] private UI_Pertanyaan _tempatPertanyaan = null;
    [SerializeField] private UI_PoinJawaban[] _tempatPilihanJawaban = new UI_PoinJawaban[0];
    
    private int _indexSoal = -1;
    //private int level = 1;

    private void Start() {
        NextLevel();
    }

    public void NextLevel() {
        _indexSoal++;

        //if (_indexSoal >= _soalSoal.Length) _indexSoal = 0;
        //DataSoal soal = _soalSoal[_indexSoal];
        //_tempatPertanyaan.SetPertanyaan($"Level {level}", soal.pertanyaan, soal.hint);

        //for (int i = 0; i < _tempatPilihanJawaban.Length; i++) {
        //    UI_PoinJawaban poin = _tempatPilihanJawaban[i];
        //    poin.SetJawaban(soal.jawabanTeks[i], soal.adalahBenar[i]);
        //}

        //level++;

        if (_indexSoal >= _soalSoal.BanyakLevel) {
            _indexSoal = 0;
        }
        LevelSoalKuis soal = _soalSoal.AmbilLevelKe(_indexSoal);
        _tempatPertanyaan.SetPertanyaan($"Level {_indexSoal + 1}", soal.pertanyaan, soal.hint);

        for (int i = 0; i < _tempatPilihanJawaban.Length; i++) {
            UI_PoinJawaban poin = _tempatPilihanJawaban[i];
            LevelSoalKuis.OpsiJawaban opsi = soal.opsiJawaban[i];
            poin.SetJawaban(opsi.jawabanTeks, opsi.adalahBenar);
        }
    }
}
