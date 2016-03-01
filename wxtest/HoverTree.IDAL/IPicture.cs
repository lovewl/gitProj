using HoverTree.Model;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace HoverTree.IDAL
{
    public interface IPicture
    {
        string Add(PictureInfo picInfo,FileUpload fileUpload);
        PictureInfo Get(PictureSelect pictureSelect);
        List<PictureInfo> HvtPageQuery(PictureSelect pictureSelect, int sortType, int pageSize, int pageIndex, out int totalCount, out int totalPageCount);
        string ReUpload(PictureInfo pictureInfo,FileUpload fileUpload);
        string AlterInfo(PictureInfo pictureInfo);
    }
}