using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.AutoWired
{
    public interface IInnerfinancecaseRepositoy //: IRepository<Innerfinancecase>
    {
        /// <summary>
        /// 新增 
        /// </summary>
        /// <returns></returns>
        String Add(string entity);

        /// <summary>
        /// 更新 
        /// </summary>
        /// <returns></returns>
        //int Update(Innerfinancecase entity);

        /// <summary>
        /// 删除 
        /// </summary>
        /// <returns></returns>
        int Delete(string entity);

        string SelectInnerfinancecaseByRootId(string rootId);
        int UpdateInnerfinanceCaseByRootId(string rootId, string receiptNum);

        bool UpdateInnerfinancecaseMoneyByRootId(string rootId, decimal money, string MoneyType);
    }
}
