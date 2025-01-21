using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetterR : MonoBehaviour, ILetter
{
    private Material mat;
    private Color currentColor;

    public void Click()
    {
        Sequence seq = DOTween.Sequence();//Сосдаем последовательность

        seq.Append(mat.DOColor(Random.ColorHSV(), 1f));//Добавляем первой смену цвета на рандомный
        seq.AppendInterval(2f);//Добавили интревал задержки времени 2 секунды
        seq.Append(mat.DOColor(currentColor, 1f));//Меняем цвет на обычный

        seq.Play();//начинаем проигрывать анимацию
    }

    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        currentColor = mat.color;
    }

}
