using IBatis.MapHelper;
using IBatis.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBatis.Service
{
    public static class UserInfoService
    {
        public static List<ContentObject> UserInfoInsertOne(ArrayList wfmids)
        {
            Hashtable param = new Hashtable();
            //param.Add("wfmids", wfmids);
            param.Add("RootId", "zhuss0520150317150535361");
            var list = Mapper.GetMaper.QueryForList<ContentObject>("IBatis.Mappers.ContentMapper.Content_DefaultSelect", param) as List<ContentObject>;
            return list;

            //Object obj = Mapper.GetMaper.Insert("UserInfo.insert_UserInfoOne", userInfo);
            //return (int)obj;
        }
        

    }
}
