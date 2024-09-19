using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fastory.Helper;
using Fastory.Core;
using System;

namespace Fastory.Mechanics
{
    public sealed class UIHandler : MonoBehaviour
    {
        [SerializeField] private GameDataConteiner dataConteiner;
  
        private void Awake()
        {
            if (dataConteiner == null)
                dataConteiner = GameObject.FindObjectOfType<GameDataConteiner> ();

        }
        private void Update()
        {
            UpdateScoreTexts();
            UpdateCostsTetxShop();
            UpdateClickPowerTextsCatShop();

        }
        /// <summary>
        /// Обновить бонусный текст клика в машазине
        /// </summary>
        private void UpdateClickPowerTextsCatShop()
        {
            for (int i = 0; i <dataConteiner.clickPowerText.Length; i++)
            {
                dataConteiner.clickPowerText[i].text = $"Click:{dataConteiner.clickPowers[i]}";
            }
        }

       /// <summary>
       /// Обновить текст цены в магазине
       /// </summary>
        private void UpdateCostsTetxShop()
        {
            for (int i = 0; i <dataConteiner.costText.Length; i++)
            {
                dataConteiner.costText[i].text = $"Cost:{dataConteiner.costs[i]}";
            }
        }
        /// <summary>
        /// Обновить текст мемной валюты
        /// </summary>
        private void UpdateScoreTexts()
        {
            for (  var index = 0; index < dataConteiner.scoreTexts.Length; index++)
            {
                dataConteiner.scoreTexts[index].text = $"Mcoin: {dataConteiner.mCoin}";
            }
           
        }
    }
}