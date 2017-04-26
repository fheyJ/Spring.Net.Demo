using IBatis.Model;
using IBatisNet.DataMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBatis.Repositoy
{
    public class TradeRepositoy //: AbstractDaoService
    {
        public List<ContentObject> GetList(ArrayList wfmids)
        {
            Hashtable param = new Hashtable();
            param.Add("wfmids", wfmids);
            //param.Add("RootId", "zhuss0520150317150535361");
            var list = Mapper.Instance().QueryForList<ContentObject>("IBatis.Mappers.ContentMapper.Content_DefaultSelect", param) as List<ContentObject>;
            return list;
        }
    }
}
