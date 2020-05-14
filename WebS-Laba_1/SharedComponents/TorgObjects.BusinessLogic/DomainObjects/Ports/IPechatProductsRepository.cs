using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TorgObjects.DomainObjects.Ports
{
    public interface IReadOnlyPechatProductsRepository
    {
        Task<PechatProducts> GetPechatProducts(long id);

        Task<IEnumerable<PechatProducts>> GetAllPechatProductss();

        Task<IEnumerable<PechatProducts>> QueryPechatProductss(ICriteria<PechatProducts> criteria);

    }

    public interface IPechatProductsRepository
    {
        Task AddPechatProducts(PechatProducts PechatProducts);

        Task RemovePechatProducts(PechatProducts PechatProducts);

        Task UpdatePechatProducts(PechatProducts PechatProducts);
    }
}
