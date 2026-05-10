using Microsoft.AspNetCore.Components;

namespace imageSharing.Client.Services
{
    public class SearchService
    {
        public SearchOption SearchBy { get; private set; } = SearchOption.None;
        public void ChangeSearchOption(ChangeEventArgs args)
        {
            if (args.Value?.ToString() == "title") SearchBy = SearchOption.Title;
            else SearchBy = SearchOption.Tags;
        }
    }
}
