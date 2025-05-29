namespace KooliProjekt.Data
{
    public class PagedResultBase
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 5; // Vaikimisi 5
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
    }
}
