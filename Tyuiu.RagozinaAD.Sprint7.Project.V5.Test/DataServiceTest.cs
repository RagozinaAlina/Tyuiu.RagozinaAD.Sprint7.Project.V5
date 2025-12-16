using Tyuiu.RagozinaAD.Sprint7.Project.V5.Lib;
namespace Tyuiu.RagozinaAD.Sprint7.Project.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SortMax()
        {
            DataService ds = new DataService();
            string[,] tab =
            {
                {"Код","Название","Количество","Стоимость" },
                {"1","Ручка шариковая","300","20"},
                {"2","Бумага офисная","220","300"},
                {"3","Скотч","150","90"},
                {"4","Блокнот","130","150"}
            };

            string[,] res = ds.SortMax(tab , 3);
            string[,] wait =
            {
                {"Код","Название","Количество","Стоимость" },
                {"2","Бумага офисная","220","300"},
                {"4","Блокнот","130","150"},
                {"3","Скотч","150","90"},
                {"1","Ручка шариковая","300","20"},
            };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestSearch()
        {
            DataService ds = new DataService();
            string[,] tab =
            {
                {"Код","Название","Количество","Стоимость" },
                {"1","Ручка шариковая","300","20"},
                {"2","Бумага офисная","220","300"},
                {"3","Скотч","150","90"},
                {"4","Блокнот","130","150"}
            };

            string[,] res = ds.Search(tab, "Бумага офисная");
            string[,] wait =
            {
                {"2","Бумага офисная","220","300"},
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

