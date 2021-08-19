﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model_Objects
{
    class Class_Weapons
    {
        //Atributos
        public string Name { get; set; }
        public string Element { get; set; }
        public string SecundaryType { get; set; }
        public int MaxLevelAllowed { get; set; }
        public int AttackCooldown { get; set; }
        public int Damage { get; set; }
        public int MaxLevelDamage { get; set; }
        public int PierceCount { get; set; }
        public bool EnablePierceAreaDamage { get; set; }
        public bool PersistAgainstProjectile { get; set; }
        public long CoinPrice { get; set; }
        public long FreemiumGoldPrice { get; set; }
        public long PremiumGoldPrice { get; set; }


        //Atributo de pesquisa
        /// <summary>
        /// Este atributo é uma string contendo a conversão de todos os atributos em texto para localizar um valor
        /// </summary>
        public string searchIn { get; set; }
    }
}