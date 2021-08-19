﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model_Objects
{
    class Class_Artifact
    {
        //Atributos
        public string Name { get; set; }
        public string Element { get; set; }
        public string SecundaryType { get; set; }
        public int MaxLevelAllowed { get; set; }
        public int Armor { get; set; }
        public int MaxLevelArmor { get; set; }
        public float MagicBoost { get; set; }
        public float SpeedBost { get; set; }
        public float JumpBoost { get; set; }
        public float ArmorBoost { get; set; }
        public float SwordBoost { get; set; }
        public float DaggerBoost { get; set; }
        public float StaffBoost { get; set; }
        public float SpearBoost { get; set; }
        public float HammerBoost { get; set; }
        public float AxeBoost { get; set; }
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
