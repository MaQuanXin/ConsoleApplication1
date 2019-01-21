using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Model> strList = new List<Model>()
            {
                new Model(){Id=1,Name = "张三"},
                new Model(){Id=2,Name = "李四"},
                new Model(){Id=3,Name = "王五"},
                new Model(){Id=4,Name = "赵六"},
                new Model(){Id=11,Name = "赵六"},
                new Model(){Id=33,Name = "赵六"},
                new Model(){Id=12,Name = "赵六"},
                new Model(){Id=34,Name = "赵六"},
                new Model(){Id=31,Name = "赵六"},
                new Model(){Id=31,Name = "第一次修改Git"},
            };

            List<int> whereList = new List<int>() { 1, 3 };

            var list = strList.Where(x => whereList.Contains(x.Id));

            foreach (var model in list)
            {
                Console.WriteLine("Id:" + model.Id + "Name:" + model.Name);
            }

            Console.ReadKey();
        }
    }

    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
