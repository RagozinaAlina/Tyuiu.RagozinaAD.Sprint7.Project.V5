using Tyuiu.RagozinaAD.Sprint7.Project.V5.Lib;
namespace Tyuiu.RagozinaAD.Sprint7.Project.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void GetMatrix()
        {
            string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint7.Project.V5\DataSprint7\Товары.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
        [TestMethod]
        public void SortMax()
        {
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
        public void SortMin()
        {
            string[,] tab =
            {
                {"Код","Название","Количество","Стоимость" },
                {"1","Ручка шариковая","300","20"},
                {"2","Бумага офисная","220","300"},
                {"3","Скотч","150","90"},
                {"4","Блокнот","130","150"}
            };

            string[,] res = ds.SortMin(tab, 2);
            string[,] wait =
            {
                {"Код","Название","Количество","Стоимость" },
                {"4","Блокнот","130","150"},
                {"3","Скотч","150","90"},
                {"2","Бумага офисная","220","300"},
                {"1","Ручка шариковая","300","20"},
            };
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestSearch()
        {
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
        [TestMethod]
        public void TestArrayStrElements()
        {
            string[,] tab =
            {
                {"Код","Название","Количество","Стоимость" },
                {"1","Ручка шариковая","300","20"},
                {"2","Бумага офисная","220","300"},
                {"3","Скотч","150","90"},
                {"4","Блокнот","130","150"}
            };

            string[] res = ds.ArrayStrElements(tab, 2);
            string[] wait = { "300", "220", "150","130" };
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestArraySum()
        {
            string[,] tab =
            {
                {"Код","Название","Количество","Стоимость" },
                {"1","Ручка шариковая","300","20"},
                {"2","Бумага офисная","220","300"},
                {"3","Скотч","150","90"},
                {"4","Блокнот","130","150"}
            };

            int[] res = ds.ArraySum(tab, ds.ArrayStrElements(tab, 2), 2);
            int[] wait = { 1, 1, 1, 1 };
            CollectionAssert.AreEqual(wait, res);
        }


    }
}

