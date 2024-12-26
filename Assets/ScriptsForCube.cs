using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NewBehaviourScript : MonoBehaviour
{
    // Серіалізовані поля для налаштувань
    [SerializeField] private Vector3 rotationAngle = new Vector3(0, 360, 0);
    [SerializeField] private float duration = 2f;
    [SerializeField] private Ease easeType = Ease.InOutElastic;
    [SerializeField] private Vector3 punchScale = new Vector3(1, 1, 1); // Нове поле для Punch Scale
    [SerializeField] private float punchDuration = 1f; // Тривалість Punch Scale
    [SerializeField] private int vibrato = 10; // Кількість коливань для Punch Scale
    [SerializeField] private float elasticity = 1f; // Еластичність для Punch Scale

    // Update is called once per frame
    void Update()
    {
        // Перевірка натискання кнопки "1"
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Вивід повідомлення в консоль
            Debug.Log("<color=green>Button '1'</color> pressed. Action: <color=blue>Rotate Object</color>");

            // Виконуємо обертання куба на 360 градусів з кастомною кривою Ease
            transform.DORotate(rotationAngle, duration, RotateMode.FastBeyond360)
                     .SetEase(easeType);
        }

        // Перевірка натискання кнопки "2"
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Вивід повідомлення в консоль
            Debug.Log("<color=green>Button '2'</color> pressed. Action: <color=blue>Punch Scale</color>");

            // Виконуємо анімацію Punch Scale
            transform.DOPunchScale(punchScale, punchDuration, vibrato, elasticity);
        }
    }
}
