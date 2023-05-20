     using System;
     using System.Collections;
using System.Collections.Generic;
using UnityEngine;
     using UnityEngine.Serialization;
     using UnityEngine.UI;

     public class UICandleController : MonoBehaviour
{
     [SerializeField] private Image candle;
     private float _yPos;
     [SerializeField] private float _burnAmount;


     private void Start()
     {
          _yPos = candle.GetComponent<RectTransform>().anchoredPosition.y;
     }

     private void Update()
     {
          BurnCandle();
     }

     public void BurnCandle()
     {
          _yPos -= _burnAmount;
          candle.GetComponent<RectTransform>().anchoredPosition = new Vector2(430, _yPos);
     }
     
     
}
