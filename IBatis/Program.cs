using IBatis.Model;
using IBatis.Repositoy;
using IBatis.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBatis
{
    class Program
    {

        //UserInfoService service = new UserInfoService();

        static void Main(string[] args)
        {
            TradeRepositoy trade = new TradeRepositoy();

            ArrayList array = new ArrayList
            {
                "016f0c3c-74e4-4292-82d5-cd588e88d927",
                "0211d028-070d-4bdb-bf45-de267f02bd0c",
                "caiwen0120130506175342738"
            };

            List<ContentObject> list = UserInfoService.UserInfoInsertOne(array);

            Console.ReadLine();

        }
    }
}
