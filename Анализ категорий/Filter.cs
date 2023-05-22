using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анализ_категорий
{
    internal class Filter
    {
        public static string filterMolecule = ""; //переменная для записи выбранных элементов в фильтре 
        public static string filterPrim = "";  
        public static string filterNazn = "";
        public static string filterProd = "";
        public static string filterProdMark = "";
        public static void setFilterMolecule(string molecule) //метод для записи выбранных элементов (молекула)
        {
            filterMolecule = molecule;
        }

        public static string getFilterMolecule() //метод получения строки выбранных элементов (молекула)
        {
            return filterMolecule;
        }

        public static void setFilterPrim(string prim) //метод для записи выбранных элементов (применение)
        {
            filterPrim = prim;
        }

        public static string getFilterPrim() //метод получения строки выбранных элементов (применение)
        {
            return filterPrim;
        }

        public static void setFilterNazn(string nazn) //метод для записи выбранных элементов (применение)
        {
            filterNazn = nazn;
        }

        public static string getFilterNazn() //метод получения строки выбранных элементов (применение)
        {
            return filterNazn;
        }

        public static void setFilterProd(string prod) //метод для записи выбранных элементов (применение)
        {
            filterProd = prod;
        }

        public static string getFilterProd() //метод получения строки выбранных элементов (применение)
        {
            return filterProd;
        }

        public static void setFilterProdMark(string prodMark) //метод для записи выбранных элементов (применение)
        {
            filterProdMark = prodMark;
        }

        public static string getFilterProdMark() //метод получения строки выбранных элементов (применение)
        {
            return filterProdMark;
        }

    }
}
