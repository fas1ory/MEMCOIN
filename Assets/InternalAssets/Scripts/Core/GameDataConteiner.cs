using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fastory.Core
{
    public sealed class GameDataConteiner : MonoBehaviour
    {
        public const double MYLTYLY_VALUE = 1.07; 
        
        [Header("Sprites")]
        public SpriteRenderer catSprite;

        [Header("GameObject")]
        public GameObject apple;
        public Transform spawnPoint;

        [Header("Score")]
        public double clickPower = 1;
        public double mCoin = 0;
        public Text[] scoreTexts;

        [Header("ShopController")]
        [Tooltip("Цена за улучшение бонуса.")]
        public double[] costs;
        [Tooltip("Бонус/награда за клик.")]
        public double[] clickPowers;
        [Space]
        public Text[] costText;
        public Text[] clickPowerText;
            
    }

}