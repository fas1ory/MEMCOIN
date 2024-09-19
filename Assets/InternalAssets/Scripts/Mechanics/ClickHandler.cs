using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fastory.Helper;
using Fastory.Core;

namespace Fastory.Mechanics
{
    public class ClickHandler : MonoBehaviour
    {
       [SerializeField] private GameDataConteiner dataConteiner;
        public void Awake()
        {
            if (dataConteiner == null)
            dataConteiner = GameObject.FindObjectOfType<GameDataConteiner>();
        }

        public void OnClick()
        {
            dataConteiner.mCoin += dataConteiner.clickPower;
            dataConteiner.catSprite.flipX = !dataConteiner.catSprite.flipX;
            Instantiate(dataConteiner.apple, dataConteiner.spawnPoint.position, Quaternion.identity);
        }  
            
    } 
}

