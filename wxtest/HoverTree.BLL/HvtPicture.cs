using HoverTree.IDAL;
using HoverTree.Model;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace HoverTree.BLL
{
   public  class HvtPicture
    {
       static readonly IPicture dal = HoverTree.DALFactory.DataAccess.CreatePicture();
       public string Add(HoverTree.Model.PictureInfo picInfo,FileUpload fileUpload)
       {
           return dal.Add(picInfo,fileUpload);
       }

       public List<PictureInfo> HvtPageQuery(PictureSelect select, int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount)
       {
           return dal.HvtPageQuery(select, sortType,  pageSize,  pageIndex, out  totalCount, out  totalPageCount);
       }

       public PictureInfo Get(PictureSelect select)
       {
           return dal.Get(select);
       }

       public string ReUpload(PictureInfo info,FileUpload fileUpload)
       {
           return dal.ReUpload(info, fileUpload);
       }

       public string AlterInfo(PictureInfo pictureInfo) 
       {
           return dal.AlterInfo(pictureInfo);
       }
    }
}