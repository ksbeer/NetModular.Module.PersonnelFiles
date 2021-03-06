using System.Threading.Tasks;
using NetModular.Module.PersonnelFiles.Application.PositionService.ViewModels;
using NetModular.Module.PersonnelFiles.Domain.Position.Models;

namespace NetModular.Module.PersonnelFiles.Application.PositionService
{
    /// <summary>
    /// 岗位服务
    /// </summary>
    public interface IPositionService
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Query(PositionQueryModel model);

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Add(PositionAddModel model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns></returns>
        Task<IResultModel> Delete(int id);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResultModel> Edit(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Update(PositionUpdateModel model);

        /// <summary>
        /// 获取单个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResultModel> Get(int id);
    }
}
