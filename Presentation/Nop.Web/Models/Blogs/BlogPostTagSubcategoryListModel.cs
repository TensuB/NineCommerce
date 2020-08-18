using System.Collections.Generic;
using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Blogs
{
    public partial class BlogPostTagSubcategoryListModel : BaseNopModel
    {
        public BlogPostTagSubcategoryListModel()
        {
            PagingFilteringContext = new BlogPagingFilteringModel();
            BlogPosts = new List<BlogPostModel>();
        }

        public int WorkingLanguageId { get; set; }
        public IList<KeyValuePair<string, int>> BlogPostSubCategoriesByCount { get; set; }  
        public string CurrentTag { get; set; }

        public BlogPagingFilteringModel PagingFilteringContext { get; set; }
        public IList<BlogPostModel> BlogPosts { get; set; }      
    }
}