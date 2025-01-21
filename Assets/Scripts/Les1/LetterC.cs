using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetterC : MonoBehaviour, ILetter
{
    private Material mat;

    public void Click()
    {
        Sequence seq = DOTween.Sequence();//Сосдаем последовательность анимации

        seq.Append(mat.DOFade(0f, 1f));//Уменьшаем прозрачность
        seq.AppendInterval(2f);//Ждем интервал
        seq.Append(mat.DOFade(1f, 1f));//Увеличиваем прозрачность

        seq.Play();
    }

    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

}
