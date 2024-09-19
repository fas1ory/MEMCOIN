using Fastory.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fastory.Mechanics
{
    public sealed class ShopController : MonoBehaviour
    {
        public GameDataConteiner dataConteiner;
        public void BuyCatShop( int id)
        {
            if (dataConteiner.mCoin <= 0) { dataConteiner.mCoin = 0; return; }
            if (dataConteiner.mCoin >= dataConteiner.costs[id] && dataConteiner.mCoin != 0)
             {
                dataConteiner.mCoin -= dataConteiner.costs[id];
                dataConteiner.costs[id] *= GameDataConteiner.MYLTYLY_VALUE;
                dataConteiner.clickPower += dataConteiner.clickPowers[id];
             } 
        }
    }
}

