using System;

namespace AngularShop.Model.Models
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdateBy { set; get; }
    }
}