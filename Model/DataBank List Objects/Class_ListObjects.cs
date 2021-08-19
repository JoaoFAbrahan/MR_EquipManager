using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Model_Objects;

namespace Model
{
    public class Class_ListObjects
    {
        public Class_ListObjects()
        {
            Armors_List = new List<Class_Armor>();
            Artifacts_List = new List<Class_Artifact>();
            Weapons_List = new List<Class_Weapons>();
        }

        //Atributos (Listas)
        private List<Class_Armor> Armors_List;
        private List<Class_Artifact> Artifacts_List;
        private List<Class_Weapons> Weapons_List;


        //Metodos para Lista Armor
        public void Add_Armor(string name, string element, string secType, 
                              int maxLevelAll, int armor, int maxLevelArm,
                              float magicBoost, float speedBoost, float jumpBoost,
                              float armorBoost, float swordBoost, float daggerBoost,
                              float staffBoost, float spearBoost, float hammerBoost, float axesBoost,
                              long coinPrice, long freeGoldPrice, long premGoldPice)
        {
            //Criando objeto
            Class_Armor obj = new Class_Armor();
            obj.Name = name;
            obj.Element = element;
            obj.SecundaryType = secType;
            obj.MaxLevelAllowed = maxLevelAll;
            obj.Armor = armor;
            obj.MaxLevelArmor = maxLevelArm;
            obj.MagicBoost = magicBoost;
            obj.SpearBoost = speedBoost;
            obj.JumpBoost = jumpBoost;
            obj.ArmorBoost = armorBoost;
            obj.SwordBoost = swordBoost;
            obj.DaggerBoost = daggerBoost;
            obj.StaffBoost = staffBoost;
            obj.SpearBoost = spearBoost;
            obj.HammerBoost = hammerBoost;
            obj.AxeBoost = axesBoost;
            obj.CoinPrice = coinPrice;
            obj.FreemiumGoldPrice = freeGoldPrice;
            obj.PremiumGoldPrice = premGoldPice;

            //Criando cadeia de strings utilizada para futuras buscas
            obj.searchIn = name + element + secType + maxLevelAll + armor + maxLevelArm + magicBoost + spearBoost + 
                jumpBoost + armorBoost + swordBoost + daggerBoost + staffBoost + spearBoost + hammerBoost + 
                axesBoost + coinPrice + freeGoldPrice + premGoldPice;
        }
        public int[] Search_Armor(string text)
        {
            //Cria uma lista temporaria
            List<int> indexList = new List<int>();

            //Busca os elementos que contenham o texto de entrada e adicionam o indice dela na lista
            for (int i = 0; i < this.Armors_List.Count; i++)
            {
                if (Armors_List[i].searchIn.Contains(text))
                {
                    indexList.Add(i);
                }
            }

            //Converte para um array
            int[] indexArray = indexList.ToArray();

            //Retorna o array resultante
            return indexArray;
        }
    }
}
