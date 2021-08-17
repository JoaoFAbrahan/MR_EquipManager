using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Model_Objects;

namespace Model.DataBank_List_Objects
{
    /// <summary>
    /// Lista do banco de dados do programa onde ficara armazenado os itens lidos no arquivo JSON
    /// </summary>
    class List_Objects
    {
        public List_Objects()
        {
            List_Armors = new List<Class_Armor>();
            //List_Artifacts = new List<Class_Artifact>();
            //List_Weapons = new List<Class_Weapon>();
        }

        //Atributos contendo os três tipos de lista
        private List<Class_Armor> List_Armors;
        //private List<Class_Artifact> List_Artifacts;
        //private List<Class_Weapon> List_Weapons;

        //Métodos de acesso aos objetos das listas
        /// <summary>
        /// Adiciona uma um novo item na lista Armor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="element"></param>
        /// <param name="secundaryType"></param>
        /// <param name="maxLevelAllowed"></param>
        /// <param name="armor"></param>
        /// <param name="maxLevelArmor"></param>
        /// <param name="magicBoost"></param>
        /// <param name="speedBoost"></param>
        /// <param name="jumpBoost"></param>
        /// <param name="armorBoost"></param>
        /// <param name="swordBoost"></param>
        /// <param name="daggerBoost"></param>
        /// <param name="staffBoost"></param>
        /// <param name="spearBoost"></param>
        /// <param name="hammerBoost"></param>
        /// <param name="axeBoost"></param>
        /// <param name="coinPrice"></param>
        /// <param name="freemiumGoldPrice"></param>
        /// <param name="premiumGoldPrice"></param>
        public void addArmor(string name, string element, string secundaryType,
                             string maxLevelAllowed, string armor, string maxLevelArmor,
                             string magicBoost, string speedBoost, string jumpBoost, string armorBoost,
                             string swordBoost, string daggerBoost, string staffBoost, string spearBoost,
                             string hammerBoost, string axeBoost,
                             string coinPrice, string freemiumGoldPrice, string premiumGoldPrice)
        {
            Class_Armor obj = new Class_Armor();

            obj.Name = name;
            obj.Element = element;
            obj.SecundaryType = secundaryType;
            obj.MaxLevelAllowed = maxLevelAllowed;
            obj.Armor = armor;
            obj.MaxLevelArmor = maxLevelArmor;
            obj.MagicBoost = magicBoost;
            obj.SpeedBost = speedBoost;
            obj.JumpBoost = jumpBoost;
            obj.ArmorBoost = armorBoost;
            obj.SwordBoost = swordBoost;
            obj.DaggerBoost = daggerBoost;
            obj.StaffBoost = staffBoost;
            obj.SpearBoost = spearBoost;
            obj.HammerBoost = hammerBoost;
            obj.AxeBoost = axeBoost;
            obj.CoinPrice = coinPrice;
            obj.FreemiumGoldPrice = freemiumGoldPrice;
            obj.PremiumGoldPrice = premiumGoldPrice;

            List_Armors.Add(obj);
        }

        public List<int> searchArmor(string text)
        {
            List<int> indexArray = new List<int>();

            for (int i = 0; i < List_Armors.Count; i++)
            {
                if (List_Armors[i].Name.Contains(text) || List_Armors[i].Element.Contains(text) || 
                    List_Armors[i].SecundaryType.Contains(text) || List_Armors[i].MaxLevelAllowed.Contains(text) || 
                    List_Armors[i].Armor.Contains(text) || List_Armors[i].MaxLevelArmor.Contains(text) ||
                    List_Armors[i].MagicBoost.Contains(text) || List_Armors[i].SpeedBost.Contains(text) ||
                    List_Armors[i].JumpBoost.Contains(text) || List_Armors[i].ArmorBoost.Contains(text) ||
                    List_Armors[i].SwordBoost.Contains(text) || List_Armors[i].DaggerBoost.Contains(text) ||
                    List_Armors[i].StaffBoost.Contains(text) || List_Armors[i].SpearBoost.Contains(text) ||
                    List_Armors[i].HammerBoost.Contains(text) || List_Armors[i].AxeBoost.Contains(text) ||
                    List_Armors[i].CoinPrice.Contains(text) || List_Armors[i].FreemiumGoldPrice.Contains(text) ||
                    List_Armors[i].PremiumGoldPrice.Contains(text))
                {
                    indexArray.Add(i);
                }
            }

            return indexArray;
        }
    }
}
